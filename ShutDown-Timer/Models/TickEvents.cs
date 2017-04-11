using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ShutDown_Timer.Models
{
    class TickEvents
    {
        // Check whether timer is on or not
        public bool IsTimerOn;

        // Flag 1 means we want to shut down the system. Use "2" to reboot.
        public int CommandFlag;
    }

    /// <summary>
    /// Manage Events For Tick Event of the timer.
    /// </summary>
    class TickEventsManager
    {
        /// <summary>
        /// 
        /// </summary>
        void Shutdown()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system.
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        void ShutDownWithCommand()
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }
    } 
}
