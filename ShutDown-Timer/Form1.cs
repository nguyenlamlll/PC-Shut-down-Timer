using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDown_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Set interval for timer: 1 second
            timer1.Interval = 1000;

            //Make the form fixed and hide maximize, minimize boxes.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        
    }
}
