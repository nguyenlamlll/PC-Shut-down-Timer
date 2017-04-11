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
            this.button_Start.Location = new System.Drawing.Point(332, 73);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 29);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Status.Location = new System.Drawing.Point(28, 166);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(21, 20);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "...";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 289);
            this.Controls.Add(this.label_Status);
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
    }
}

