using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShutDown_Timer.Models;

namespace ShutDown_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Set interval for timer: 1 second
            timer1.Interval = 1000;
            timer1.Stop();
            TickEvents.IsTimerOn = true;

            //Make the form fixed and hide maximize, minimize boxes.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void pictureBox_ShutDown_Click(object sender, EventArgs e)
        {
            TickEvents.CommandFlag = (int)FlagEnum.ForceShutDown;
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            TickEvents.CommandFlag = (int)FlagEnum.ForceReboot;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            int interval = Int32.Parse(comboBox_Seconds.SelectedItem.ToString());
            ShutDownManager.ShutDown(TickEvents.CommandFlag, interval, timer1, label_Status);
        }
    }
}
