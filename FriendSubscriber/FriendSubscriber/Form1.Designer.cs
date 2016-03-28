namespace FriendSubscriber
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMe = new System.Windows.Forms.TabPage();
            this.tabPageFriend1 = new System.Windows.Forms.TabPage();
            this.tabPageFriend2 = new System.Windows.Forms.TabPage();
            this.buttonUpdateMe = new System.Windows.Forms.Button();
            this.textBoxMyInput = new System.Windows.Forms.TextBox();
            this.listBoxMyFeed = new System.Windows.Forms.ListBox();
            this.listBoxFriend1Display = new System.Windows.Forms.ListBox();
            this.textBoxFriend1Input = new System.Windows.Forms.TextBox();
            this.buttonFriend1Update = new System.Windows.Forms.Button();
            this.listBoxFriend2Display = new System.Windows.Forms.ListBox();
            this.textBoxFriend2Input = new System.Windows.Forms.TextBox();
            this.buttonFriend2Update = new System.Windows.Forms.Button();
            this.buttonAddFriend1 = new System.Windows.Forms.Button();
            this.buttonAddFriend2 = new System.Windows.Forms.Button();
            this.buttonClearFeed = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageMe.SuspendLayout();
            this.tabPageFriend1.SuspendLayout();
            this.tabPageFriend2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMe);
            this.tabControl.Controls.Add(this.tabPageFriend1);
            this.tabControl.Controls.Add(this.tabPageFriend2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 579);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageMe
            // 
            this.tabPageMe.Controls.Add(this.buttonClearFeed);
            this.tabPageMe.Controls.Add(this.listBoxMyFeed);
            this.tabPageMe.Controls.Add(this.textBoxMyInput);
            this.tabPageMe.Controls.Add(this.buttonUpdateMe);
            this.tabPageMe.Location = new System.Drawing.Point(4, 29);
            this.tabPageMe.Name = "tabPageMe";
            this.tabPageMe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMe.Size = new System.Drawing.Size(793, 546);
            this.tabPageMe.TabIndex = 0;
            this.tabPageMe.Text = "My profile";
            this.tabPageMe.UseVisualStyleBackColor = true;
            // 
            // tabPageFriend1
            // 
            this.tabPageFriend1.Controls.Add(this.buttonAddFriend1);
            this.tabPageFriend1.Controls.Add(this.listBoxFriend1Display);
            this.tabPageFriend1.Controls.Add(this.textBoxFriend1Input);
            this.tabPageFriend1.Controls.Add(this.buttonFriend1Update);
            this.tabPageFriend1.Location = new System.Drawing.Point(4, 29);
            this.tabPageFriend1.Name = "tabPageFriend1";
            this.tabPageFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriend1.Size = new System.Drawing.Size(793, 546);
            this.tabPageFriend1.TabIndex = 1;
            this.tabPageFriend1.Text = "Friend1";
            this.tabPageFriend1.UseVisualStyleBackColor = true;
            // 
            // tabPageFriend2
            // 
            this.tabPageFriend2.Controls.Add(this.buttonAddFriend2);
            this.tabPageFriend2.Controls.Add(this.listBoxFriend2Display);
            this.tabPageFriend2.Controls.Add(this.textBoxFriend2Input);
            this.tabPageFriend2.Controls.Add(this.buttonFriend2Update);
            this.tabPageFriend2.Location = new System.Drawing.Point(4, 29);
            this.tabPageFriend2.Name = "tabPageFriend2";
            this.tabPageFriend2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriend2.Size = new System.Drawing.Size(793, 546);
            this.tabPageFriend2.TabIndex = 2;
            this.tabPageFriend2.Text = "Friend2";
            this.tabPageFriend2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateMe
            // 
            this.buttonUpdateMe.Location = new System.Drawing.Point(25, 408);
            this.buttonUpdateMe.Name = "buttonUpdateMe";
            this.buttonUpdateMe.Size = new System.Drawing.Size(219, 58);
            this.buttonUpdateMe.TabIndex = 0;
            this.buttonUpdateMe.Text = "Update Status";
            this.buttonUpdateMe.UseVisualStyleBackColor = true;
            this.buttonUpdateMe.Click += new System.EventHandler(this.buttonUpdateMe_Click);
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(366, 471);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(326, 26);
            this.textBoxMyInput.TabIndex = 1;
            // 
            // listBoxMyFeed
            // 
            this.listBoxMyFeed.FormattingEnabled = true;
            this.listBoxMyFeed.ItemHeight = 20;
            this.listBoxMyFeed.Location = new System.Drawing.Point(89, 38);
            this.listBoxMyFeed.Name = "listBoxMyFeed";
            this.listBoxMyFeed.Size = new System.Drawing.Size(602, 344);
            this.listBoxMyFeed.TabIndex = 2;
            // 
            // listBoxFriend1Display
            // 
            this.listBoxFriend1Display.FormattingEnabled = true;
            this.listBoxFriend1Display.ItemHeight = 20;
            this.listBoxFriend1Display.Location = new System.Drawing.Point(122, 36);
            this.listBoxFriend1Display.Name = "listBoxFriend1Display";
            this.listBoxFriend1Display.Size = new System.Drawing.Size(602, 344);
            this.listBoxFriend1Display.TabIndex = 5;
            // 
            // textBoxFriend1Input
            // 
            this.textBoxFriend1Input.Location = new System.Drawing.Point(399, 469);
            this.textBoxFriend1Input.Name = "textBoxFriend1Input";
            this.textBoxFriend1Input.Size = new System.Drawing.Size(326, 26);
            this.textBoxFriend1Input.TabIndex = 4;
            // 
            // buttonFriend1Update
            // 
            this.buttonFriend1Update.Location = new System.Drawing.Point(68, 453);
            this.buttonFriend1Update.Name = "buttonFriend1Update";
            this.buttonFriend1Update.Size = new System.Drawing.Size(219, 58);
            this.buttonFriend1Update.TabIndex = 3;
            this.buttonFriend1Update.Text = "Update Status";
            this.buttonFriend1Update.UseVisualStyleBackColor = true;
            this.buttonFriend1Update.Click += new System.EventHandler(this.buttonFriend1Update_Click);
            // 
            // listBoxFriend2Display
            // 
            this.listBoxFriend2Display.FormattingEnabled = true;
            this.listBoxFriend2Display.ItemHeight = 20;
            this.listBoxFriend2Display.Location = new System.Drawing.Point(122, 36);
            this.listBoxFriend2Display.Name = "listBoxFriend2Display";
            this.listBoxFriend2Display.Size = new System.Drawing.Size(602, 344);
            this.listBoxFriend2Display.TabIndex = 5;
            // 
            // textBoxFriend2Input
            // 
            this.textBoxFriend2Input.Location = new System.Drawing.Point(399, 469);
            this.textBoxFriend2Input.Name = "textBoxFriend2Input";
            this.textBoxFriend2Input.Size = new System.Drawing.Size(326, 26);
            this.textBoxFriend2Input.TabIndex = 4;
            // 
            // buttonFriend2Update
            // 
            this.buttonFriend2Update.Location = new System.Drawing.Point(68, 453);
            this.buttonFriend2Update.Name = "buttonFriend2Update";
            this.buttonFriend2Update.Size = new System.Drawing.Size(219, 58);
            this.buttonFriend2Update.TabIndex = 3;
            this.buttonFriend2Update.Text = "Update Status";
            this.buttonFriend2Update.UseVisualStyleBackColor = true;
            this.buttonFriend2Update.Click += new System.EventHandler(this.buttonFriend2Update_Click);
            // 
            // buttonAddFriend1
            // 
            this.buttonAddFriend1.Location = new System.Drawing.Point(20, 50);
            this.buttonAddFriend1.Name = "buttonAddFriend1";
            this.buttonAddFriend1.Size = new System.Drawing.Size(80, 80);
            this.buttonAddFriend1.TabIndex = 6;
            this.buttonAddFriend1.Text = "Add this friend";
            this.buttonAddFriend1.UseVisualStyleBackColor = true;
            this.buttonAddFriend1.Click += new System.EventHandler(this.buttonAddFriend1_Click);
            // 
            // buttonAddFriend2
            // 
            this.buttonAddFriend2.Location = new System.Drawing.Point(20, 50);
            this.buttonAddFriend2.Name = "buttonAddFriend2";
            this.buttonAddFriend2.Size = new System.Drawing.Size(80, 80);
            this.buttonAddFriend2.TabIndex = 6;
            this.buttonAddFriend2.Text = "Add this friend";
            this.buttonAddFriend2.UseVisualStyleBackColor = true;
            this.buttonAddFriend2.Click += new System.EventHandler(this.buttonAddFriend2_Click);
            // 
            // buttonClearFeed
            // 
            this.buttonClearFeed.Location = new System.Drawing.Point(25, 472);
            this.buttonClearFeed.Name = "buttonClearFeed";
            this.buttonClearFeed.Size = new System.Drawing.Size(219, 58);
            this.buttonClearFeed.TabIndex = 3;
            this.buttonClearFeed.Text = "Clear News Feed";
            this.buttonClearFeed.UseVisualStyleBackColor = true;
            this.buttonClearFeed.Click += new System.EventHandler(this.buttonClearFeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 603);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageMe.ResumeLayout(false);
            this.tabPageMe.PerformLayout();
            this.tabPageFriend1.ResumeLayout(false);
            this.tabPageFriend1.PerformLayout();
            this.tabPageFriend2.ResumeLayout(false);
            this.tabPageFriend2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMe;
        private System.Windows.Forms.TabPage tabPageFriend1;
        private System.Windows.Forms.ListBox listBoxMyFeed;
        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Button buttonUpdateMe;
        private System.Windows.Forms.ListBox listBoxFriend1Display;
        private System.Windows.Forms.TextBox textBoxFriend1Input;
        private System.Windows.Forms.Button buttonFriend1Update;
        private System.Windows.Forms.TabPage tabPageFriend2;
        private System.Windows.Forms.ListBox listBoxFriend2Display;
        private System.Windows.Forms.TextBox textBoxFriend2Input;
        private System.Windows.Forms.Button buttonFriend2Update;
        private System.Windows.Forms.Button buttonAddFriend1;
        private System.Windows.Forms.Button buttonAddFriend2;
        private System.Windows.Forms.Button buttonClearFeed;
    }
}

