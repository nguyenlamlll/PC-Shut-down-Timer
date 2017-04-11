using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutDown_Timer
{
    /// <summary>
    /// Flag Enumerations for WMI commands
    /// </summary>
    public enum FlagEnum
    {
       LogOff = 0,
       ForceLogOff = 4,
       ShutDown = 1,
       ForceShutDown = 5,
       Reboot = 2,
       ForceReboot = 6,
       PowerOff = 8,
       ForcePowerOff = 12
    }
}
