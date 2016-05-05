namespace Progress_Display
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxfeedback = new System.Windows.Forms.GroupBox();
            this.radioButtonProgressBar = new System.Windows.Forms.RadioButton();
            this.radioButtonTrackBar = new System.Windows.Forms.RadioButton();
            this.radioButtonSpinBox = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.spinBox = new System.Windows.Forms.NumericUpDown();
            this.groupBoxfeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(103, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(183, 76);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxfeedback
            // 
            this.groupBoxfeedback.Controls.Add(this.radioButtonProgressBar);
            this.groupBoxfeedback.Controls.Add(this.radioButtonTrackBar);
            this.groupBoxfeedback.Controls.Add(this.radioButtonSpinBox);
            this.groupBoxfeedback.Location = new System.Drawing.Point(513, 101);
            this.groupBoxfeedback.Name = "groupBoxfeedback";
            this.groupBoxfeedback.Size = new System.Drawing.Size(307, 298);
            this.groupBoxfeedback.TabIndex = 1;
            this.groupBoxfeedback.TabStop = false;
            this.groupBoxfeedback.Text = "Feedback";
            // 
            // radioButtonProgressBar
            // 
            this.radioButtonProgressBar.AutoSize = true;
            this.radioButtonProgressBar.Location = new System.Drawing.Point(64, 190);
            this.radioButtonProgressBar.Name = "radioButtonProgressBar";
            this.radioButtonProgressBar.Size = new System.Drawing.Size(126, 24);
            this.radioButtonProgressBar.TabIndex = 2;
            this.radioButtonProgressBar.Text = "Progress Bar";
            this.radioButtonProgressBar.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrackBar
            // 
            this.radioButtonTrackBar.AutoSize = true;
            this.radioButtonTrackBar.Location = new System.Drawing.Point(64, 135);
            this.radioButtonTrackBar.Name = "radioButtonTrackBar";
            this.radioButtonTrackBar.Size = new System.Drawing.Size(102, 24);
            this.radioButtonTrackBar.TabIndex = 1;
            this.radioButtonTrackBar.Text = "Track Bar";
            this.radioButtonTrackBar.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpinBox
            // 
            this.radioButtonSpinBox.AutoSize = true;
            this.radioButtonSpinBox.Checked = true;
            this.radioButtonSpinBox.Location = new System.Drawing.Point(64, 74);
            this.radioButtonSpinBox.Name = "radioButtonSpinBox";
            this.radioButtonSpinBox.Size = new System.Drawing.Size(97, 24);
            this.radioButtonSpinBox.TabIndex = 0;
            this.radioButtonSpinBox.TabStop = true;
            this.radioButtonSpinBox.Text = "Spin Box";
            this.radioButtonSpinBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(149, 495);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(582, 43);
            this.progressBar.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(149, 585);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(582, 69);
            this.trackBar.TabIndex = 3;
            // 
            // spinBox
            // 
            this.spinBox.Location = new System.Drawing.Point(149, 394);
            this.spinBox.Name = "spinBox";
            this.spinBox.Size = new System.Drawing.Size(120, 26);
            this.spinBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 691);
            this.Controls.Add(this.spinBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBoxfeedback);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxfeedback.ResumeLayout(false);
            this.groupBoxfeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxfeedback;
        private System.Windows.Forms.RadioButton radioButtonProgressBar;
        private System.Windows.Forms.RadioButton radioButtonTrackBar;
        private System.Windows.Forms.RadioButton radioButtonSpinBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.NumericUpDown spinBox;
    }
}

