namespace ProgressBarUsingEventHandler
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
            this.spinBox = new System.Windows.Forms.NumericUpDown();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // spinBox
            // 
            this.spinBox.Location = new System.Drawing.Point(88, 365);
            this.spinBox.Name = "spinBox";
            this.spinBox.Size = new System.Drawing.Size(120, 26);
            this.spinBox.TabIndex = 9;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(88, 556);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(582, 69);
            this.trackBar.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(88, 466);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(582, 43);
            this.progressBar.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(42, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(183, 76);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 745);
            this.Controls.Add(this.spinBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spinBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
    }
}

