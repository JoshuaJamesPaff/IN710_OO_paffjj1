namespace Game_Character
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCharacterType = new System.Windows.Forms.GroupBox();
            this.rdTroll = new System.Windows.Forms.RadioButton();
            this.rdKnight = new System.Windows.Forms.RadioButton();
            this.rdQueen = new System.Windows.Forms.RadioButton();
            this.rdKing = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.checkedListBoxCharacters = new System.Windows.Forms.CheckedListBox();
            this.listBoxBattle = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBow = new System.Windows.Forms.RadioButton();
            this.rdKnife = new System.Windows.Forms.RadioButton();
            this.rdSword = new System.Windows.Forms.RadioButton();
            this.checkedListBoxWeapon = new System.Windows.Forms.CheckedListBox();
            this.buttonChangeWeapon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxCharacterType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBoxCharacterType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAddCharacter);
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(18, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 260);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // groupBoxCharacterType
            // 
            this.groupBoxCharacterType.Controls.Add(this.rdTroll);
            this.groupBoxCharacterType.Controls.Add(this.rdKnight);
            this.groupBoxCharacterType.Controls.Add(this.rdQueen);
            this.groupBoxCharacterType.Controls.Add(this.rdKing);
            this.groupBoxCharacterType.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCharacterType.Location = new System.Drawing.Point(408, 28);
            this.groupBoxCharacterType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCharacterType.Name = "groupBoxCharacterType";
            this.groupBoxCharacterType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCharacterType.Size = new System.Drawing.Size(242, 212);
            this.groupBoxCharacterType.TabIndex = 12;
            this.groupBoxCharacterType.TabStop = false;
            this.groupBoxCharacterType.Text = "Character Type";
            // 
            // rdTroll
            // 
            this.rdTroll.AutoSize = true;
            this.rdTroll.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTroll.Location = new System.Drawing.Point(19, 159);
            this.rdTroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTroll.Name = "rdTroll";
            this.rdTroll.Size = new System.Drawing.Size(100, 35);
            this.rdTroll.TabIndex = 3;
            this.rdTroll.TabStop = true;
            this.rdTroll.Text = "Troll";
            this.rdTroll.UseVisualStyleBackColor = true;
            // 
            // rdKnight
            // 
            this.rdKnight.AutoSize = true;
            this.rdKnight.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnight.Location = new System.Drawing.Point(19, 120);
            this.rdKnight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKnight.Name = "rdKnight";
            this.rdKnight.Size = new System.Drawing.Size(131, 35);
            this.rdKnight.TabIndex = 2;
            this.rdKnight.TabStop = true;
            this.rdKnight.Text = "Knight";
            this.rdKnight.UseVisualStyleBackColor = true;
            // 
            // rdQueen
            // 
            this.rdQueen.AutoSize = true;
            this.rdQueen.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQueen.Location = new System.Drawing.Point(19, 81);
            this.rdQueen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdQueen.Name = "rdQueen";
            this.rdQueen.Size = new System.Drawing.Size(117, 35);
            this.rdQueen.TabIndex = 1;
            this.rdQueen.TabStop = true;
            this.rdQueen.Text = "Queen";
            this.rdQueen.UseVisualStyleBackColor = true;
            // 
            // rdKing
            // 
            this.rdKing.AutoSize = true;
            this.rdKing.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKing.Location = new System.Drawing.Point(19, 42);
            this.rdKing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKing.Name = "rdKing";
            this.rdKing.Size = new System.Drawing.Size(104, 35);
            this.rdKing.TabIndex = 0;
            this.rdKing.TabStop = true;
            this.rdKing.Text = "King";
            this.rdKing.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 40);
            this.txtName.TabIndex = 9;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.Location = new System.Drawing.Point(30, 28);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(323, 49);
            this.btnAddCharacter.TabIndex = 8;
            this.btnAddCharacter.Text = "Create New Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBattle);
            this.panel2.Controls.Add(this.checkedListBoxCharacters);
            this.panel2.Controls.Add(this.listBoxBattle);
            this.panel2.Location = new System.Drawing.Point(18, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 520);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "To Battle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Two Combatants";
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(333, 52);
            this.btnBattle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(326, 54);
            this.btnBattle.TabIndex = 22;
            this.btnBattle.Text = "Battle!";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // checkedListBoxCharacters
            // 
            this.checkedListBoxCharacters.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCharacters.FormattingEnabled = true;
            this.checkedListBoxCharacters.Location = new System.Drawing.Point(17, 122);
            this.checkedListBoxCharacters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxCharacters.Name = "checkedListBoxCharacters";
            this.checkedListBoxCharacters.Size = new System.Drawing.Size(300, 354);
            this.checkedListBoxCharacters.TabIndex = 21;
            // 
            // listBoxBattle
            // 
            this.listBoxBattle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBattle.FormattingEnabled = true;
            this.listBoxBattle.ItemHeight = 31;
            this.listBoxBattle.Location = new System.Drawing.Point(333, 124);
            this.listBoxBattle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxBattle.Name = "listBoxBattle";
            this.listBoxBattle.Size = new System.Drawing.Size(331, 345);
            this.listBoxBattle.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.checkedListBoxWeapon);
            this.panel3.Controls.Add(this.buttonChangeWeapon);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(724, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 806);
            this.panel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBow);
            this.groupBox2.Controls.Add(this.rdKnife);
            this.groupBox2.Controls.Add(this.rdSword);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(242, 165);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Weapon";
            // 
            // rdBow
            // 
            this.rdBow.AutoSize = true;
            this.rdBow.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBow.Location = new System.Drawing.Point(19, 120);
            this.rdBow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBow.Name = "rdBow";
            this.rdBow.Size = new System.Drawing.Size(95, 35);
            this.rdBow.TabIndex = 2;
            this.rdBow.Text = "Bow";
            this.rdBow.UseVisualStyleBackColor = true;
            // 
            // rdKnife
            // 
            this.rdKnife.AutoSize = true;
            this.rdKnife.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnife.Location = new System.Drawing.Point(19, 81);
            this.rdKnife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKnife.Name = "rdKnife";
            this.rdKnife.Size = new System.Drawing.Size(112, 35);
            this.rdKnife.TabIndex = 1;
            this.rdKnife.Text = "Knife";
            this.rdKnife.UseVisualStyleBackColor = true;
            // 
            // rdSword
            // 
            this.rdSword.AutoSize = true;
            this.rdSword.Checked = true;
            this.rdSword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSword.Location = new System.Drawing.Point(19, 42);
            this.rdSword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdSword.Name = "rdSword";
            this.rdSword.Size = new System.Drawing.Size(120, 35);
            this.rdSword.TabIndex = 0;
            this.rdSword.TabStop = true;
            this.rdSword.Text = "Sword";
            this.rdSword.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxWeapon
            // 
            this.checkedListBoxWeapon.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxWeapon.FormattingEnabled = true;
            this.checkedListBoxWeapon.Location = new System.Drawing.Point(25, 68);
            this.checkedListBoxWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxWeapon.Name = "checkedListBoxWeapon";
            this.checkedListBoxWeapon.Size = new System.Drawing.Size(300, 354);
            this.checkedListBoxWeapon.TabIndex = 27;
            // 
            // buttonChangeWeapon
            // 
            this.buttonChangeWeapon.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeWeapon.Location = new System.Drawing.Point(25, 736);
            this.buttonChangeWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeWeapon.Name = "buttonChangeWeapon";
            this.buttonChangeWeapon.Size = new System.Drawing.Size(300, 54);
            this.buttonChangeWeapon.TabIndex = 25;
            this.buttonChangeWeapon.Text = " Change Weapon";
            this.buttonChangeWeapon.UseVisualStyleBackColor = true;
            this.buttonChangeWeapon.Click += new System.EventHandler(this.buttonChangeWeapon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 848);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Battle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCharacterType.ResumeLayout(false);
            this.groupBoxCharacterType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCharacterType;
        private System.Windows.Forms.RadioButton rdTroll;
        private System.Windows.Forms.RadioButton rdKnight;
        private System.Windows.Forms.RadioButton rdQueen;
        private System.Windows.Forms.RadioButton rdKing;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.CheckedListBox checkedListBoxCharacters;
        private System.Windows.Forms.ListBox listBoxBattle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonChangeWeapon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeapon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBow;
        private System.Windows.Forms.RadioButton rdKnife;
        private System.Windows.Forms.RadioButton rdSword;
    }
}

