namespace FireAlarm
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
            this.buttonActivateAlarm = new System.Windows.Forms.Button();
            this.groupBoxFireType = new System.Windows.Forms.GroupBox();
            this.radioButtonInferno = new System.Windows.Forms.RadioButton();
            this.radioButtonSerious = new System.Windows.Forms.RadioButton();
            this.radioButtonMinor = new System.Windows.Forms.RadioButton();
            this.groupBoxFireType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonActivateAlarm
            // 
            this.buttonActivateAlarm.BackColor = System.Drawing.Color.Red;
            this.buttonActivateAlarm.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonActivateAlarm.ForeColor = System.Drawing.Color.White;
            this.buttonActivateAlarm.Location = new System.Drawing.Point(128, 98);
            this.buttonActivateAlarm.Name = "buttonActivateAlarm";
            this.buttonActivateAlarm.Size = new System.Drawing.Size(365, 173);
            this.buttonActivateAlarm.TabIndex = 0;
            this.buttonActivateAlarm.Text = "Activate Alarm";
            this.buttonActivateAlarm.UseVisualStyleBackColor = false;
            this.buttonActivateAlarm.Click += new System.EventHandler(this.buttonActivateAlarm_Click);
            // 
            // groupBoxFireType
            // 
            this.groupBoxFireType.Controls.Add(this.radioButtonInferno);
            this.groupBoxFireType.Controls.Add(this.radioButtonSerious);
            this.groupBoxFireType.Controls.Add(this.radioButtonMinor);
            this.groupBoxFireType.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFireType.Location = new System.Drawing.Point(128, 292);
            this.groupBoxFireType.Name = "groupBoxFireType";
            this.groupBoxFireType.Size = new System.Drawing.Size(365, 367);
            this.groupBoxFireType.TabIndex = 1;
            this.groupBoxFireType.TabStop = false;
            this.groupBoxFireType.Text = "Fire Type";
            // 
            // radioButtonInferno
            // 
            this.radioButtonInferno.AutoSize = true;
            this.radioButtonInferno.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInferno.Location = new System.Drawing.Point(45, 271);
            this.radioButtonInferno.Name = "radioButtonInferno";
            this.radioButtonInferno.Size = new System.Drawing.Size(120, 33);
            this.radioButtonInferno.TabIndex = 2;
            this.radioButtonInferno.Text = "Inferno";
            this.radioButtonInferno.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerious
            // 
            this.radioButtonSerious.AutoSize = true;
            this.radioButtonSerious.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSerious.Location = new System.Drawing.Point(45, 172);
            this.radioButtonSerious.Name = "radioButtonSerious";
            this.radioButtonSerious.Size = new System.Drawing.Size(120, 33);
            this.radioButtonSerious.TabIndex = 1;
            this.radioButtonSerious.Text = "Serious";
            this.radioButtonSerious.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinor
            // 
            this.radioButtonMinor.AutoSize = true;
            this.radioButtonMinor.Checked = true;
            this.radioButtonMinor.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMinor.Location = new System.Drawing.Point(45, 78);
            this.radioButtonMinor.Name = "radioButtonMinor";
            this.radioButtonMinor.Size = new System.Drawing.Size(104, 33);
            this.radioButtonMinor.TabIndex = 0;
            this.radioButtonMinor.TabStop = true;
            this.radioButtonMinor.Text = "Minor";
            this.radioButtonMinor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 767);
            this.Controls.Add(this.groupBoxFireType);
            this.Controls.Add(this.buttonActivateAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxFireType.ResumeLayout(false);
            this.groupBoxFireType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonActivateAlarm;
        private System.Windows.Forms.GroupBox groupBoxFireType;
        private System.Windows.Forms.RadioButton radioButtonInferno;
        private System.Windows.Forms.RadioButton radioButtonSerious;
        private System.Windows.Forms.RadioButton radioButtonMinor;
    }
}

