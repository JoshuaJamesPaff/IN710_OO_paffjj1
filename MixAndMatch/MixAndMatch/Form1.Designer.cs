namespace MixAndMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxMiddle = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom = new System.Windows.Forms.PictureBox();
            this.labelHead = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.labelLegs = new System.Windows.Forms.Label();
            this.comboBoxHead = new System.Windows.Forms.ComboBox();
            this.comboBoxBody = new System.Windows.Forms.ComboBox();
            this.comboBoxLegs = new System.Windows.Forms.ComboBox();
            this.buttonMakeMonster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTop
            // 
            this.pictureBoxTop.ImageLocation = "";
            this.pictureBoxTop.InitialImage = null;
            this.pictureBoxTop.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTop.Name = "pictureBoxTop";
            this.pictureBoxTop.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxTop.TabIndex = 0;
            this.pictureBoxTop.TabStop = false;
            // 
            // pictureBoxMiddle
            // 
            this.pictureBoxMiddle.ImageLocation = "";
            this.pictureBoxMiddle.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiddle.InitialImage")));
            this.pictureBoxMiddle.Location = new System.Drawing.Point(12, 418);
            this.pictureBoxMiddle.Name = "pictureBoxMiddle";
            this.pictureBoxMiddle.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxMiddle.TabIndex = 1;
            this.pictureBoxMiddle.TabStop = false;
            // 
            // pictureBoxBottom
            // 
            this.pictureBoxBottom.ImageLocation = "";
            this.pictureBoxBottom.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBottom.InitialImage")));
            this.pictureBoxBottom.Location = new System.Drawing.Point(12, 824);
            this.pictureBoxBottom.Name = "pictureBoxBottom";
            this.pictureBoxBottom.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxBottom.TabIndex = 2;
            this.pictureBoxBottom.TabStop = false;
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Location = new System.Drawing.Point(767, 110);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(52, 20);
            this.labelHead.TabIndex = 3;
            this.labelHead.Text = "Head:";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(767, 174);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(49, 20);
            this.labelBody.TabIndex = 4;
            this.labelBody.Text = "Body:";
            // 
            // labelLegs
            // 
            this.labelLegs.AutoSize = true;
            this.labelLegs.Location = new System.Drawing.Point(767, 242);
            this.labelLegs.Name = "labelLegs";
            this.labelLegs.Size = new System.Drawing.Size(48, 20);
            this.labelLegs.TabIndex = 5;
            this.labelLegs.Text = "Legs:";
            // 
            // comboBoxHead
            // 
            this.comboBoxHead.FormattingEnabled = true;
            this.comboBoxHead.Location = new System.Drawing.Point(825, 110);
            this.comboBoxHead.Name = "comboBoxHead";
            this.comboBoxHead.Size = new System.Drawing.Size(307, 28);
            this.comboBoxHead.TabIndex = 6;
            // 
            // comboBoxBody
            // 
            this.comboBoxBody.FormattingEnabled = true;
            this.comboBoxBody.Location = new System.Drawing.Point(822, 174);
            this.comboBoxBody.Name = "comboBoxBody";
            this.comboBoxBody.Size = new System.Drawing.Size(307, 28);
            this.comboBoxBody.TabIndex = 7;
            // 
            // comboBoxLegs
            // 
            this.comboBoxLegs.FormattingEnabled = true;
            this.comboBoxLegs.Location = new System.Drawing.Point(821, 239);
            this.comboBoxLegs.Name = "comboBoxLegs";
            this.comboBoxLegs.Size = new System.Drawing.Size(307, 28);
            this.comboBoxLegs.TabIndex = 8;
            // 
            // buttonMakeMonster
            // 
            this.buttonMakeMonster.Location = new System.Drawing.Point(875, 452);
            this.buttonMakeMonster.Name = "buttonMakeMonster";
            this.buttonMakeMonster.Size = new System.Drawing.Size(163, 51);
            this.buttonMakeMonster.TabIndex = 9;
            this.buttonMakeMonster.Text = "Make Monster";
            this.buttonMakeMonster.UseVisualStyleBackColor = true;
            this.buttonMakeMonster.Click += new System.EventHandler(this.buttonMakeMonster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1233);
            this.Controls.Add(this.buttonMakeMonster);
            this.Controls.Add(this.comboBoxLegs);
            this.Controls.Add(this.comboBoxBody);
            this.Controls.Add(this.comboBoxHead);
            this.Controls.Add(this.labelLegs);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelHead);
            this.Controls.Add(this.pictureBoxBottom);
            this.Controls.Add(this.pictureBoxMiddle);
            this.Controls.Add(this.pictureBoxTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTop;
        private System.Windows.Forms.PictureBox pictureBoxMiddle;
        private System.Windows.Forms.PictureBox pictureBoxBottom;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelLegs;
        private System.Windows.Forms.ComboBox comboBoxHead;
        private System.Windows.Forms.ComboBox comboBoxBody;
        private System.Windows.Forms.ComboBox comboBoxLegs;
        private System.Windows.Forms.Button buttonMakeMonster;
    }
}

