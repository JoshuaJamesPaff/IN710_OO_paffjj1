namespace Clocks
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
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.groupBoxClockType = new System.Windows.Forms.GroupBox();
            this.radioButtonAnalog = new System.Windows.Forms.RadioButton();
            this.radioButtonDigital = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxClockType.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(194, 239);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(283, 283);
            this.analogClock.TabIndex = 0;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigitalClock.Location = new System.Drawing.Point(222, 350);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(227, 59);
            this.labelDigitalClock.TabIndex = 1;
            this.labelDigitalClock.Text = "00:00:00";
            // 
            // groupBoxClockType
            // 
            this.groupBoxClockType.Controls.Add(this.radioButtonAnalog);
            this.groupBoxClockType.Controls.Add(this.radioButtonDigital);
            this.groupBoxClockType.Location = new System.Drawing.Point(415, 109);
            this.groupBoxClockType.Name = "groupBoxClockType";
            this.groupBoxClockType.Size = new System.Drawing.Size(200, 138);
            this.groupBoxClockType.TabIndex = 2;
            this.groupBoxClockType.TabStop = false;
            this.groupBoxClockType.Enter += new System.EventHandler(this.groupBoxClockType_Enter);
            // 
            // radioButtonAnalog
            // 
            this.radioButtonAnalog.AutoSize = true;
            this.radioButtonAnalog.Location = new System.Drawing.Point(37, 76);
            this.radioButtonAnalog.Name = "radioButtonAnalog";
            this.radioButtonAnalog.Size = new System.Drawing.Size(84, 24);
            this.radioButtonAnalog.TabIndex = 1;
            this.radioButtonAnalog.Text = "Analog";
            this.radioButtonAnalog.UseVisualStyleBackColor = true;
            this.radioButtonAnalog.CheckedChanged += new System.EventHandler(this.radioButtonAnalog_CheckedChanged);
            // 
            // radioButtonDigital
            // 
            this.radioButtonDigital.AutoSize = true;
            this.radioButtonDigital.Checked = true;
            this.radioButtonDigital.Location = new System.Drawing.Point(37, 34);
            this.radioButtonDigital.Name = "radioButtonDigital";
            this.radioButtonDigital.Size = new System.Drawing.Size(78, 24);
            this.radioButtonDigital.TabIndex = 0;
            this.radioButtonDigital.TabStop = true;
            this.radioButtonDigital.Text = "Digital";
            this.radioButtonDigital.UseVisualStyleBackColor = true;
            this.radioButtonDigital.CheckedChanged += new System.EventHandler(this.radioButtonDigital_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(139, 130);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 51);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(139, 187);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(114, 51);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 642);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxClockType);
            this.Controls.Add(this.labelDigitalClock);
            this.Controls.Add(this.analogClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxClockType.ResumeLayout(false);
            this.groupBoxClockType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.Timer timerDigitalClock;
        private System.Windows.Forms.Label labelDigitalClock;
        private System.Windows.Forms.GroupBox groupBoxClockType;
        private System.Windows.Forms.RadioButton radioButtonAnalog;
        private System.Windows.Forms.RadioButton radioButtonDigital;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}

