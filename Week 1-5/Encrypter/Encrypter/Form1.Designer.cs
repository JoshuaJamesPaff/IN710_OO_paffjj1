namespace Encrypter
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
            this.groupBoxSecurity = new System.Windows.Forms.GroupBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.radioButtonStringReversal = new System.Windows.Forms.RadioButton();
            this.radioButtonROT13 = new System.Windows.Forms.RadioButton();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSecurity
            // 
            this.groupBoxSecurity.Controls.Add(this.radioButtonROT13);
            this.groupBoxSecurity.Controls.Add(this.radioButtonStringReversal);
            this.groupBoxSecurity.Location = new System.Drawing.Point(34, 45);
            this.groupBoxSecurity.Name = "groupBoxSecurity";
            this.groupBoxSecurity.Size = new System.Drawing.Size(200, 151);
            this.groupBoxSecurity.TabIndex = 0;
            this.groupBoxSecurity.TabStop = false;
            this.groupBoxSecurity.Text = "Encryption";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(548, 71);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(119, 53);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // radioButtonStringReversal
            // 
            this.radioButtonStringReversal.AutoSize = true;
            this.radioButtonStringReversal.Checked = true;
            this.radioButtonStringReversal.Location = new System.Drawing.Point(27, 40);
            this.radioButtonStringReversal.Name = "radioButtonStringReversal";
            this.radioButtonStringReversal.Size = new System.Drawing.Size(142, 24);
            this.radioButtonStringReversal.TabIndex = 0;
            this.radioButtonStringReversal.TabStop = true;
            this.radioButtonStringReversal.Text = "String Reversal";
            this.radioButtonStringReversal.UseVisualStyleBackColor = true;
            // 
            // radioButtonROT13
            // 
            this.radioButtonROT13.AutoSize = true;
            this.radioButtonROT13.Location = new System.Drawing.Point(27, 93);
            this.radioButtonROT13.Name = "radioButtonROT13";
            this.radioButtonROT13.Size = new System.Drawing.Size(85, 24);
            this.radioButtonROT13.TabIndex = 1;
            this.radioButtonROT13.Text = "ROT13";
            this.radioButtonROT13.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(261, 96);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(226, 26);
            this.textBoxInput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(257, 57);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(113, 20);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Text to encrypt";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(54, 290);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(123, 37);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(548, 158);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(119, 53);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(183, 300);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(381, 26);
            this.textBoxOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 710);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBoxSecurity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSecurity.ResumeLayout(false);
            this.groupBoxSecurity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSecurity;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonStringReversal;
        private System.Windows.Forms.RadioButton radioButtonROT13;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

