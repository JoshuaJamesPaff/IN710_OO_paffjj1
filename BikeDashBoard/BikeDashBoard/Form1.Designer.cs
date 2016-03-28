namespace BikeDashBoard
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
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelCurrentRPM = new System.Windows.Forms.Label();
            this.labelCurrentCalories = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelCurrentVelocity = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.buttonSetRPM = new System.Windows.Forms.Button();
            this.textBoxRPMInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPM.Location = new System.Drawing.Point(292, 216);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(70, 35);
            this.labelRPM.TabIndex = 0;
            this.labelRPM.Text = "RPM";
            // 
            // labelCurrentRPM
            // 
            this.labelCurrentRPM.AutoSize = true;
            this.labelCurrentRPM.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentRPM.Location = new System.Drawing.Point(413, 216);
            this.labelCurrentRPM.Name = "labelCurrentRPM";
            this.labelCurrentRPM.Size = new System.Drawing.Size(159, 35);
            this.labelCurrentRPM.TabIndex = 1;
            this.labelCurrentRPM.Text = "CurrentRPM";
            // 
            // labelCurrentCalories
            // 
            this.labelCurrentCalories.AutoSize = true;
            this.labelCurrentCalories.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentCalories.Location = new System.Drawing.Point(413, 373);
            this.labelCurrentCalories.Name = "labelCurrentCalories";
            this.labelCurrentCalories.Size = new System.Drawing.Size(197, 35);
            this.labelCurrentCalories.TabIndex = 3;
            this.labelCurrentCalories.Text = "CurrentCalories";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalories.Location = new System.Drawing.Point(292, 373);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(108, 35);
            this.labelCalories.TabIndex = 2;
            this.labelCalories.Text = "Calories";
            // 
            // labelCurrentVelocity
            // 
            this.labelCurrentVelocity.AutoSize = true;
            this.labelCurrentVelocity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentVelocity.Location = new System.Drawing.Point(413, 527);
            this.labelCurrentVelocity.Name = "labelCurrentVelocity";
            this.labelCurrentVelocity.Size = new System.Drawing.Size(198, 35);
            this.labelCurrentVelocity.TabIndex = 5;
            this.labelCurrentVelocity.Text = "CurrentVelocity";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocity.Location = new System.Drawing.Point(292, 527);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(109, 35);
            this.labelVelocity.TabIndex = 4;
            this.labelVelocity.Text = "Velocity";
            // 
            // buttonSetRPM
            // 
            this.buttonSetRPM.Location = new System.Drawing.Point(730, 216);
            this.buttonSetRPM.Name = "buttonSetRPM";
            this.buttonSetRPM.Size = new System.Drawing.Size(215, 74);
            this.buttonSetRPM.TabIndex = 6;
            this.buttonSetRPM.Text = "Set RPM";
            this.buttonSetRPM.UseVisualStyleBackColor = true;
            this.buttonSetRPM.Click += new System.EventHandler(this.buttonSetRPM_Click);
            // 
            // textBoxRPMInput
            // 
            this.textBoxRPMInput.Location = new System.Drawing.Point(730, 166);
            this.textBoxRPMInput.Name = "textBoxRPMInput";
            this.textBoxRPMInput.Size = new System.Drawing.Size(215, 26);
            this.textBoxRPMInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 848);
            this.Controls.Add(this.textBoxRPMInput);
            this.Controls.Add(this.buttonSetRPM);
            this.Controls.Add(this.labelCurrentVelocity);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelCurrentCalories);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelCurrentRPM);
            this.Controls.Add(this.labelRPM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Label labelCurrentRPM;
        private System.Windows.Forms.Label labelCurrentCalories;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelCurrentVelocity;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Button buttonSetRPM;
        private System.Windows.Forms.TextBox textBoxRPMInput;
    }
}

