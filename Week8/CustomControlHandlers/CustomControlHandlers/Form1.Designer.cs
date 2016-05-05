namespace CustomControlHandlers
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
            this.buttonTestHandlers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTestHandlers
            // 
            this.buttonTestHandlers.Location = new System.Drawing.Point(96, 130);
            this.buttonTestHandlers.Name = "buttonTestHandlers";
            this.buttonTestHandlers.Size = new System.Drawing.Size(272, 179);
            this.buttonTestHandlers.TabIndex = 0;
            this.buttonTestHandlers.Text = "Test Handlers";
            this.buttonTestHandlers.UseVisualStyleBackColor = true;
            this.buttonTestHandlers.Click += new System.EventHandler(this.buttonTestHandlers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 449);
            this.Controls.Add(this.buttonTestHandlers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestHandlers;
    }
}

