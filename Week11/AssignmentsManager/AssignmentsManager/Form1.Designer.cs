namespace AssignmentsManager
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
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonAllPapers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(364, 32);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(571, 584);
            this.listBoxOutput.TabIndex = 0;
            // 
            // buttonAllPapers
            // 
            this.buttonAllPapers.Location = new System.Drawing.Point(78, 96);
            this.buttonAllPapers.Name = "buttonAllPapers";
            this.buttonAllPapers.Size = new System.Drawing.Size(194, 79);
            this.buttonAllPapers.TabIndex = 1;
            this.buttonAllPapers.Text = "List All Papers";
            this.buttonAllPapers.UseVisualStyleBackColor = true;
            this.buttonAllPapers.Click += new System.EventHandler(this.buttonAllPapers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Assignments due for next two weeks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "Average assignment mark for each paper";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 655);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAllPapers);
            this.Controls.Add(this.listBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonAllPapers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

