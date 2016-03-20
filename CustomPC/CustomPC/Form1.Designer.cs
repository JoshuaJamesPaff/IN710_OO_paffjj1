namespace CustomPC
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
            this.buttonPrintPC = new System.Windows.Forms.Button();
            this.listBoxDisplaySpecs = new System.Windows.Forms.ListBox();
            this.groupBoxPCtype = new System.Windows.Forms.GroupBox();
            this.rbMultimediaPC = new System.Windows.Forms.RadioButton();
            this.rbBusinessPC = new System.Windows.Forms.RadioButton();
            this.rbGamingPC = new System.Windows.Forms.RadioButton();
            this.rbLaptop = new System.Windows.Forms.RadioButton();
            this.groupBoxPCtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintPC
            // 
            this.buttonPrintPC.Location = new System.Drawing.Point(34, 115);
            this.buttonPrintPC.Name = "buttonPrintPC";
            this.buttonPrintPC.Size = new System.Drawing.Size(186, 62);
            this.buttonPrintPC.TabIndex = 0;
            this.buttonPrintPC.Text = "Print Spec";
            this.buttonPrintPC.UseVisualStyleBackColor = true;
            this.buttonPrintPC.Click += new System.EventHandler(this.buttonPrintPC_Click);
            // 
            // listBoxDisplaySpecs
            // 
            this.listBoxDisplaySpecs.FormattingEnabled = true;
            this.listBoxDisplaySpecs.ItemHeight = 20;
            this.listBoxDisplaySpecs.Location = new System.Drawing.Point(396, 115);
            this.listBoxDisplaySpecs.Name = "listBoxDisplaySpecs";
            this.listBoxDisplaySpecs.Size = new System.Drawing.Size(472, 464);
            this.listBoxDisplaySpecs.TabIndex = 1;
            // 
            // groupBoxPCtype
            // 
            this.groupBoxPCtype.Controls.Add(this.rbLaptop);
            this.groupBoxPCtype.Controls.Add(this.rbMultimediaPC);
            this.groupBoxPCtype.Controls.Add(this.rbBusinessPC);
            this.groupBoxPCtype.Controls.Add(this.rbGamingPC);
            this.groupBoxPCtype.Location = new System.Drawing.Point(34, 231);
            this.groupBoxPCtype.Name = "groupBoxPCtype";
            this.groupBoxPCtype.Size = new System.Drawing.Size(186, 201);
            this.groupBoxPCtype.TabIndex = 2;
            this.groupBoxPCtype.TabStop = false;
            this.groupBoxPCtype.Text = "PC Type";
            // 
            // rbMultimediaPC
            // 
            this.rbMultimediaPC.AutoSize = true;
            this.rbMultimediaPC.Location = new System.Drawing.Point(6, 120);
            this.rbMultimediaPC.Name = "rbMultimediaPC";
            this.rbMultimediaPC.Size = new System.Drawing.Size(135, 24);
            this.rbMultimediaPC.TabIndex = 2;
            this.rbMultimediaPC.TabStop = true;
            this.rbMultimediaPC.Text = "Multimedia PC";
            this.rbMultimediaPC.UseVisualStyleBackColor = true;
            // 
            // rbBusinessPC
            // 
            this.rbBusinessPC.AutoSize = true;
            this.rbBusinessPC.Location = new System.Drawing.Point(6, 90);
            this.rbBusinessPC.Name = "rbBusinessPC";
            this.rbBusinessPC.Size = new System.Drawing.Size(124, 24);
            this.rbBusinessPC.TabIndex = 1;
            this.rbBusinessPC.TabStop = true;
            this.rbBusinessPC.Text = "Business PC";
            this.rbBusinessPC.UseVisualStyleBackColor = true;
            // 
            // rbGamingPC
            // 
            this.rbGamingPC.AutoSize = true;
            this.rbGamingPC.Checked = true;
            this.rbGamingPC.Location = new System.Drawing.Point(6, 60);
            this.rbGamingPC.Name = "rbGamingPC";
            this.rbGamingPC.Size = new System.Drawing.Size(115, 24);
            this.rbGamingPC.TabIndex = 0;
            this.rbGamingPC.TabStop = true;
            this.rbGamingPC.Text = "Gaming PC";
            this.rbGamingPC.UseVisualStyleBackColor = true;
            // 
            // rbLaptop
            // 
            this.rbLaptop.AutoSize = true;
            this.rbLaptop.Location = new System.Drawing.Point(6, 150);
            this.rbLaptop.Name = "rbLaptop";
            this.rbLaptop.Size = new System.Drawing.Size(109, 24);
            this.rbLaptop.TabIndex = 3;
            this.rbLaptop.TabStop = true;
            this.rbLaptop.Text = "Laptop PC";
            this.rbLaptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 825);
            this.Controls.Add(this.groupBoxPCtype);
            this.Controls.Add(this.listBoxDisplaySpecs);
            this.Controls.Add(this.buttonPrintPC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPCtype.ResumeLayout(false);
            this.groupBoxPCtype.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintPC;
        private System.Windows.Forms.ListBox listBoxDisplaySpecs;
        private System.Windows.Forms.GroupBox groupBoxPCtype;
        private System.Windows.Forms.RadioButton rbMultimediaPC;
        private System.Windows.Forms.RadioButton rbBusinessPC;
        private System.Windows.Forms.RadioButton rbGamingPC;
        private System.Windows.Forms.RadioButton rbLaptop;
    }
}

