using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShutDown_Timer.Models;
using System.Windows.Forms;

namespace ShutDown_Timer
{
    /// <summary>
    /// Middle layer.
    /// </summary>
    static class ShutDownManager
    {
        public static void ShutDown(int flag, Timer timer1)
        {

            if (TickEvents.CommandFlag == 5)
                try
                {
                    timer1.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
