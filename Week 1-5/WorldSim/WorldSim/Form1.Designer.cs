namespace WorldSim
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
            this.listBoxAnimalOutput = new System.Windows.Forms.ListBox();
            this.buttonAfrica = new System.Windows.Forms.Button();
            this.buttonStraya = new System.Windows.Forms.Button();
            this.buttonAmerica = new System.Windows.Forms.Button();
            this.panelAnimalGraphics = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxAnimalOutput
            // 
            this.listBoxAnimalOutput.FormattingEnabled = true;
            this.listBoxAnimalOutput.ItemHeight = 20;
            this.listBoxAnimalOutput.Location = new System.Drawing.Point(531, 7);
            this.listBoxAnimalOutput.Name = "listBoxAnimalOutput";
            this.listBoxAnimalOutput.Size = new System.Drawing.Size(562, 504);
            this.listBoxAnimalOutput.TabIndex = 0;
            // 
            // buttonAfrica
            // 
            this.buttonAfrica.Location = new System.Drawing.Point(531, 556);
            this.buttonAfrica.Name = "buttonAfrica";
            this.buttonAfrica.Size = new System.Drawing.Size(151, 61);
            this.buttonAfrica.TabIndex = 1;
            this.buttonAfrica.Text = "Africa";
            this.buttonAfrica.UseVisualStyleBackColor = true;
            this.buttonAfrica.Click += new System.EventHandler(this.buttonAfrica_Click);
            // 
            // buttonStraya
            // 
            this.buttonStraya.Location = new System.Drawing.Point(738, 556);
            this.buttonStraya.Name = "buttonStraya";
            this.buttonStraya.Size = new System.Drawing.Size(151, 61);
            this.buttonStraya.TabIndex = 2;
            this.buttonStraya.Text = "Straya";
            this.buttonStraya.UseVisualStyleBackColor = true;
            this.buttonStraya.Click += new System.EventHandler(this.buttonStraya_Click);
            // 
            // buttonAmerica
            // 
            this.buttonAmerica.Location = new System.Drawing.Point(942, 556);
            this.buttonAmerica.Name = "buttonAmerica";
            this.buttonAmerica.Size = new System.Drawing.Size(151, 61);
            this.buttonAmerica.TabIndex = 3;
            this.buttonAmerica.Text = "America";
            this.buttonAmerica.UseVisualStyleBackColor = true;
            this.buttonAmerica.Click += new System.EventHandler(this.buttonAmerica_Click);
            // 
            // panelAnimalGraphics
            // 
            this.panelAnimalGraphics.Location = new System.Drawing.Point(7, 7);
            this.panelAnimalGraphics.Name = "panelAnimalGraphics";
            this.panelAnimalGraphics.Size = new System.Drawing.Size(500, 978);
            this.panelAnimalGraphics.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 1035);
            this.Controls.Add(this.panelAnimalGraphics);
            this.Controls.Add(this.buttonAmerica);
            this.Controls.Add(this.buttonStraya);
            this.Controls.Add(this.buttonAfrica);
            this.Controls.Add(this.listBoxAnimalOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAnimalOutput;
        private System.Windows.Forms.Button buttonAfrica;
        private System.Windows.Forms.Button buttonStraya;
        private System.Windows.Forms.Button buttonAmerica;
        private System.Windows.Forms.Panel panelAnimalGraphics;
    }
}

