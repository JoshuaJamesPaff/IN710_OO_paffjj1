namespace QuizScorer
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
            this.groupBoxTeamType = new System.Windows.Forms.GroupBox();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.radioButtonChild = new System.Windows.Forms.RadioButton();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.textBoxIncorrect = new System.Windows.Forms.TextBox();
            this.buttonComputeScore = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.groupBoxTeamType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTeamType
            // 
            this.groupBoxTeamType.Controls.Add(this.radioButtonChild);
            this.groupBoxTeamType.Controls.Add(this.radioButtonAdult);
            this.groupBoxTeamType.Location = new System.Drawing.Point(72, 73);
            this.groupBoxTeamType.Name = "groupBoxTeamType";
            this.groupBoxTeamType.Size = new System.Drawing.Size(188, 261);
            this.groupBoxTeamType.TabIndex = 0;
            this.groupBoxTeamType.TabStop = false;
            this.groupBoxTeamType.Text = "Team type";
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.Checked = true;
            this.radioButtonAdult.Location = new System.Drawing.Point(49, 83);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(71, 24);
            this.radioButtonAdult.TabIndex = 0;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "Adult";
            this.radioButtonAdult.UseVisualStyleBackColor = true;
            // 
            // radioButtonChild
            // 
            this.radioButtonChild.AutoSize = true;
            this.radioButtonChild.Location = new System.Drawing.Point(49, 164);
            this.radioButtonChild.Name = "radioButtonChild";
            this.radioButtonChild.Size = new System.Drawing.Size(69, 24);
            this.radioButtonChild.TabIndex = 1;
            this.radioButtonChild.TabStop = true;
            this.radioButtonChild.Text = "Child";
            this.radioButtonChild.UseVisualStyleBackColor = true;
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(481, 112);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(126, 20);
            this.labelCorrect.TabIndex = 1;
            this.labelCorrect.Text = "Correct Answers";
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Location = new System.Drawing.Point(481, 208);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(137, 20);
            this.labelIncorrect.TabIndex = 2;
            this.labelIncorrect.Text = "Incorrect Answers";
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.Location = new System.Drawing.Point(679, 106);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(127, 26);
            this.textBoxCorrect.TabIndex = 3;
            // 
            // textBoxIncorrect
            // 
            this.textBoxIncorrect.Location = new System.Drawing.Point(679, 205);
            this.textBoxIncorrect.Name = "textBoxIncorrect";
            this.textBoxIncorrect.Size = new System.Drawing.Size(127, 26);
            this.textBoxIncorrect.TabIndex = 4;
            // 
            // buttonComputeScore
            // 
            this.buttonComputeScore.Location = new System.Drawing.Point(124, 473);
            this.buttonComputeScore.Name = "buttonComputeScore";
            this.buttonComputeScore.Size = new System.Drawing.Size(212, 67);
            this.buttonComputeScore.TabIndex = 5;
            this.buttonComputeScore.Text = "Compute Score";
            this.buttonComputeScore.UseVisualStyleBackColor = true;
            this.buttonComputeScore.Click += new System.EventHandler(this.buttonComputeScore_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(588, 487);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(30, 31);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 723);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonComputeScore);
            this.Controls.Add(this.textBoxIncorrect);
            this.Controls.Add(this.textBoxCorrect);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.groupBoxTeamType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxTeamType.ResumeLayout(false);
            this.groupBoxTeamType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTeamType;
        private System.Windows.Forms.RadioButton radioButtonChild;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.TextBox textBoxCorrect;
        private System.Windows.Forms.TextBox textBoxIncorrect;
        private System.Windows.Forms.Button buttonComputeScore;
        private System.Windows.Forms.Label labelScore;
    }
}

