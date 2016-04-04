namespace PredicateNumbers
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonEven = new System.Windows.Forms.Button();
            this.buttonUnder10 = new System.Windows.Forms.Button();
            this.listBoxAllNums = new System.Windows.Forms.ListBox();
            this.listBoxSelectedNums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(63, 55);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(216, 82);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate Randoms";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonEven
            // 
            this.buttonEven.Location = new System.Drawing.Point(517, 31);
            this.buttonEven.Name = "buttonEven";
            this.buttonEven.Size = new System.Drawing.Size(216, 56);
            this.buttonEven.TabIndex = 1;
            this.buttonEven.Text = "Select Even Numbers";
            this.buttonEven.UseVisualStyleBackColor = true;
            this.buttonEven.Click += new System.EventHandler(this.buttonEven_Click);
            // 
            // buttonUnder10
            // 
            this.buttonUnder10.Location = new System.Drawing.Point(517, 93);
            this.buttonUnder10.Name = "buttonUnder10";
            this.buttonUnder10.Size = new System.Drawing.Size(216, 58);
            this.buttonUnder10.TabIndex = 2;
            this.buttonUnder10.Text = "Select numbers < 10";
            this.buttonUnder10.UseVisualStyleBackColor = true;
            this.buttonUnder10.Click += new System.EventHandler(this.buttonUnder10_Click);
            // 
            // listBoxAllNums
            // 
            this.listBoxAllNums.FormattingEnabled = true;
            this.listBoxAllNums.ItemHeight = 20;
            this.listBoxAllNums.Location = new System.Drawing.Point(63, 201);
            this.listBoxAllNums.Name = "listBoxAllNums";
            this.listBoxAllNums.Size = new System.Drawing.Size(216, 364);
            this.listBoxAllNums.TabIndex = 3;
            // 
            // listBoxSelectedNums
            // 
            this.listBoxSelectedNums.FormattingEnabled = true;
            this.listBoxSelectedNums.ItemHeight = 20;
            this.listBoxSelectedNums.Location = new System.Drawing.Point(517, 201);
            this.listBoxSelectedNums.Name = "listBoxSelectedNums";
            this.listBoxSelectedNums.Size = new System.Drawing.Size(216, 364);
            this.listBoxSelectedNums.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 637);
            this.Controls.Add(this.listBoxSelectedNums);
            this.Controls.Add(this.listBoxAllNums);
            this.Controls.Add(this.buttonUnder10);
            this.Controls.Add(this.buttonEven);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonEven;
        private System.Windows.Forms.Button buttonUnder10;
        private System.Windows.Forms.ListBox listBoxAllNums;
        private System.Windows.Forms.ListBox listBoxSelectedNums;
    }
}

