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
        private static int timerTime { get; set; }
        private static Label timerStatus { get; set; }
        public static void ShutDown(int flag, int interval, Timer timer1, Label status)
        {
            if (TickEvents.CommandFlag == 5)
                try
                {
                    timer1.Tick += new EventHandler(TimerOnTick);

                    timerTime = interval;
                    timerStatus = status;
                    status.Text = interval.ToString(); //Set the first second before counting down
                    timer1.Start();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private static void TimerOnTick(object obj, EventArgs ea)
        {
            timerTime -= 1;

            timerStatus.Text = timerTime.ToString();
            if (timerTime == 0)
            {
                Timer timer = (Timer)obj;
                timer.Stop();
                timer.Tick -= new EventHandler(TimerOnTick);
                MessageBox.Show("Done!");
            }

        }
    }
}
