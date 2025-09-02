using AudioSwitcher.AudioApi;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicMute.CustomTriggers
{
    public class VolumeChangeSequenceObserver : IObserver<DeviceVolumeChangedArgs>, IMuteEvent
    {
        const int MAX_HISTORY_QUEUE_SIZE = 10;
        private LinkedList<VolumeLevelHistoryItem> _volumeChangeHistory = new LinkedList<VolumeLevelHistoryItem>();
        protected int _volumeChangeStepForToggle;

        public event MuteToggled OnMute;
        public event MuteToggled OnUnMute;

        private VolumeChangeSequenceObserver()
        {
            
        }

        public VolumeChangeSequenceObserver(IDevice volumeDevice, int volumeChangeStepForToggle)
        {
            _volumeChangeStepForToggle = volumeChangeStepForToggle;
            
            var startVolume = volumeDevice.Volume;
            var vlhi = new VolumeLevelHistoryItem(startVolume);
            _volumeChangeHistory.AddLast(vlhi);

            volumeDevice.VolumeChanged.Subscribe(this);
        }

        public void ChangeVolumeChangeStepForToggle(int newVolumeChangeStepForToggle)
        {
            _volumeChangeStepForToggle = newVolumeChangeStepForToggle;
        }

        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(DeviceVolumeChangedArgs value)
        {
            var currentVolume = new VolumeLevelHistoryItem(value.Volume);

            // keep queue size small
            if (_volumeChangeHistory.Count > MAX_HISTORY_QUEUE_SIZE)
            {
                _volumeChangeHistory.RemoveFirst();
            }
            _volumeChangeHistory.AddLast(currentVolume);

            var current = _volumeChangeHistory.Last;
            var prev = current?.Previous;
            var prev2 = prev?.Previous;

            var lastStepChange = Math.Abs(current.Value.Volume - prev.Value.Volume);
            var twoStepsChange = Math.Abs(current.Value.Volume - prev2.Value.Volume);

            // if volume goes up and down (or down and up) same level within 1 second
            if (prev2 != null &&
                twoStepsChange < 1 &&
                Math.Abs(lastStepChange - _volumeChangeStepForToggle) < 1 &&
                (current.Value.Timestamp - prev.Value.Timestamp).TotalSeconds < 1)
            {
                if (current.Value.Volume > prev.Value.Volume)
                {
                    OnMute?.Invoke();
                }
                else
                {                    
                    OnUnMute?.Invoke();
                }

                // clear all history, except current item
                _volumeChangeHistory = new LinkedList<VolumeLevelHistoryItem>();
                _volumeChangeHistory.AddLast(currentVolume);
            }
        }
    }
}
