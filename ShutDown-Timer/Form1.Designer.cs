namespace ShutDown_Timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Restart = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShutDown = new System.Windows.Forms.PictureBox();
            this.label_Help = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.comboBox_Seconds = new System.Windows.Forms.ComboBox();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.comboBox_Minutes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShutDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Restart
            // 
            this.pictureBox_Restart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_Restart.BackgroundImage = global::ShutDown_Timer.Properties.Resources.restart_icon;
            this.pictureBox_Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Restart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Restart.Image = global::ShutDown_Timer.Properties.Resources.shut_down_icon;
            this.pictureBox_Restart.Location = new System.Drawing.Point(66, 0);
            this.pictureBox_Restart.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Restart.Name = "pictureBox_Restart";
            this.pictureBox_Restart.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Restart.TabIndex = 0;
            this.pictureBox_Restart.TabStop = false;
            this.pictureBox_Restart.Click += new System.EventHandler(this.pictureBoxRestart_Click);
            // 
            // pictureBox_ShutDown
            // 
            this.pictureBox_ShutDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_ShutDown.BackgroundImage = global::ShutDown_Timer.Properties.Resources.shut_down_icon;
            this.pictureBox_ShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ShutDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_ShutDown.Image = global::ShutDown_Timer.Properties.Resources.shut_down_icon;
            this.pictureBox_ShutDown.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ShutDown.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_ShutDown.Name = "pictureBox_ShutDown";
            this.pictureBox_ShutDown.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_ShutDown.TabIndex = 0;
            this.pictureBox_ShutDown.TabStop = false;
            this.pictureBox_ShutDown.Click += new System.EventHandler(this.pictureBox_ShutDown_Click);
            // 
            // label_Help
            // 
            this.label_Help.AutoSize = true;
            this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Help.Location = new System.Drawing.Point(133, 25);
            this.label_Help.Name = "label_Help";
            this.label_Help.Size = new System.Drawing.Size(199, 25);
            this.label_Help.TabIndex = 1;
            this.label_Help.Text = "Select Desired Action";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Start.Location = new System.Drawing.Point(270, 143);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(113, 29);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Status.Location = new System.Drawing.Point(50, 204);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 25);
            this.label_Status.TabIndex = 3;
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Timer.Location = new System.Drawing.Point(12, 77);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(103, 25);
            this.label_Timer.TabIndex = 1;
            this.label_Timer.Text = "Set Timer:";
            // 
            // comboBox_Seconds
            // 
            this.comboBox_Seconds.Enabled = false;
            this.comboBox_Seconds.FormattingEnabled = true;
            this.comboBox_Seconds.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Seconds.Location = new System.Drawing.Point(270, 77);
            this.comboBox_Seconds.Name = "comboBox_Seconds";
            this.comboBox_Seconds.Size = new System.Drawing.Size(62, 24);
            this.comboBox_Seconds.TabIndex = 4;
            // 
            // label_Seconds
            // 
            this.label_Seconds.AutoSize = true;
            this.label_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Seconds.Location = new System.Drawing.Point(338, 82);
            this.label_Seconds.Name = "label_Seconds";
            this.label_Seconds.Size = new System.Drawing.Size(45, 20);
            this.label_Seconds.TabIndex = 5;
            this.label_Seconds.Text = "secs";
            // 
            // comboBox_Minutes
            // 
            this.comboBox_Minutes.Enabled = false;
            this.comboBox_Minutes.FormattingEnabled = true;
            this.comboBox_Minutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Minutes.Location = new System.Drawing.Point(138, 78);
            this.comboBox_Minutes.Name = "comboBox_Minutes";
            this.comboBox_Minutes.Size = new System.Drawing.Size(62, 24);
            this.comboBox_Minutes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(206, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "mins";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Cancel.Location = new System.Drawing.Point(270, 178);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(113, 29);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Seconds);
            this.Controls.Add(this.comboBox_Minutes);
            this.Controls.Add(this.comboBox_Seconds);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label_Help);
            this.Controls.Add(this.pictureBox_Restart);
            this.Controls.Add(this.pictureBox_ShutDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShutDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ShutDown;
        private System.Windows.Forms.PictureBox pictureBox_Restart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Help;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.ComboBox comboBox_Seconds;
        private System.Windows.Forms.Label label_Seconds;
        private System.Windows.Forms.ComboBox comboBox_Minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
    }
}

