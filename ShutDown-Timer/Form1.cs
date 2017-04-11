﻿using System;
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
            TickEvents.CommandFlag = FlagEnum.ForceShutDown;
            comboBox_Minutes.Enabled = true;
            comboBox_Seconds.Enabled = true;
            if (pictureBox_ShutDown.BackColor != SystemColors.ControlDark)
            {
                pictureBox_ShutDown.BackColor = SystemColors.ControlDark;
                pictureBox_Restart.BackColor = SystemColors.Control;
            }       
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            TickEvents.CommandFlag = FlagEnum.ForceReboot;
            comboBox_Minutes.Enabled = true;
            comboBox_Seconds.Enabled = true;
            if (pictureBox_Restart.BackColor != SystemColors.ControlDark)
            {
                pictureBox_Restart.BackColor = SystemColors.ControlDark;
                pictureBox_ShutDown.BackColor = SystemColors.Control;
            }
                
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            var item = comboBox_Seconds.SelectedItem;
            int interval = 0;
            if (item != null) interval = Int32.Parse(item.ToString());
            ShutDownManager.ShutDown(TickEvents.CommandFlag, interval, timer1, label_Status);
        }
    }
}
