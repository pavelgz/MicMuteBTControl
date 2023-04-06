using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicMute.CustomTriggers
{
    public delegate void MuteToggled();

    public interface IMuteEvent
    {
        event MuteToggled OnMute;
        event MuteToggled OnUnMute;
    }    
}
