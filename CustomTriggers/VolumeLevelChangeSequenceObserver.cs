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

        public event MuteToggled OnMute;
        public event MuteToggled OnUnMute;

        private VolumeChangeSequenceObserver()
        {
            
        }

        public VolumeChangeSequenceObserver(IDevice volumeDevice)
        {
            var startVolume = volumeDevice.Volume;
            var vlhi = new VolumeLevelHistoryItem(startVolume);
            _volumeChangeHistory.AddLast(vlhi);

            volumeDevice.VolumeChanged.Subscribe(this);
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

            // if volume goes up and down (or down and up) same level within 1 second
            if (prev2 != null &&
                Math.Abs(current.Value.Volume - prev2.Value.Volume) < 1 &&
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
