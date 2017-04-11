using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ShutDown_Timer.Models
{
    static class TickEvents
    {
        // Check whether timer is on or not
        public static bool IsTimerOn { get; set; }
        /* Flags:
           - 0 (0x0) Log Off
           - 4 (0x4) Forced Log Off (0 4)
           - 1 (0x1) Shutdown
           - 5 (0x5) Forced Shutdown (1 4)
           - 2 (0x2) Reboot
           - 6 (0x6) Forced Reboot (2 4)
           - 8 (0x8) Power Off
           - 12 (0xC) Forced Power Off (8 4)
        */
        public static int CommandFlag { get; set; }
    }

    /// <summary>
    /// Manage Events For Tick Event of the timer.
    /// </summary>
    static class TickEventsManager
    {
        /// <summary>
        /// Shut down computer using WMI (Windows Management Instrumentation)
        /// For more information, read here: https://en.wikipedia.org/wiki/Windows_Management_Instrumentation
        /// </summary>
        static void Shutdown()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 5: Force Shut down
            mboShutdownParams["Flags"] = "5";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        /// <summary>
        /// Shut down by calling shutdown.exe (built-in application for Windows OS)
        /// </summary>
        static void ShutDownWithCommand()
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }
        
      
    }
}
