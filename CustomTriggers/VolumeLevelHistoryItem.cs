using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicMute.CustomTriggers
{
    public class VolumeLevelHistoryItem
    {
        private VolumeLevelHistoryItem()
        {

        }

        public VolumeLevelHistoryItem(double volume) : this(volume, DateTime.Now)
        {
            
        }

        public VolumeLevelHistoryItem(double volume, DateTime timestamp)
        {
            Volume = volume;
            Timestamp = timestamp;
        }

        public double Volume { get; private set; }
        public DateTime Timestamp { get; private set; }
    }
}
