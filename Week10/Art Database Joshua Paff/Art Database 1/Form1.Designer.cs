namespace Art_Database_1
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
            this.btnAllPaintings = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnItaly = new System.Windows.Forms.Button();
            this.btnBefore1800 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOldest = new System.Windows.Forms.Button();
            this.buttonPaintedBy = new System.Windows.Forms.Button();
            this.textBoxArtistInput = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnNbyCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllPaintings
            // 
            this.btnAllPaintings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPaintings.Location = new System.Drawing.Point(33, 20);
            this.btnAllPaintings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllPaintings.Name = "btnAllPaintings";
            this.btnAllPaintings.Size = new System.Drawing.Size(226, 39);
            this.btnAllPaintings.TabIndex = 0;
            this.btnAllPaintings.Text = "All Paintings";
            this.btnAllPaintings.UseVisualStyleBackColor = true;
            this.btnAllPaintings.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(33, 320);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1400, 550);
            this.listBox1.TabIndex = 1;
            // 
            // btnItaly
            // 
            this.btnItaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaly.Location = new System.Drawing.Point(33, 66);
            this.btnItaly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItaly.Name = "btnItaly";
            this.btnItaly.Size = new System.Drawing.Size(226, 39);
            this.btnItaly.TabIndex = 2;
            this.btnItaly.Text = "Artists from Italy";
            this.btnItaly.UseVisualStyleBackColor = true;
            this.btnItaly.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBefore1800
            // 
            this.btnBefore1800.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore1800.Location = new System.Drawing.Point(33, 112);
            this.btnBefore1800.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBefore1800.Name = "btnBefore1800";
            this.btnBefore1800.Size = new System.Drawing.Size(226, 39);
            this.btnBefore1800.TabIndex = 3;
            this.btnBefore1800.Text = "Paintings Before 1800";
            this.btnBefore1800.UseVisualStyleBackColor = true;
            this.btnBefore1800.Click += new System.EventHandler(this.btnBefore1800_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(603, 159);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(422, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "All Paintings with Artist and Artist\'s Country";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOldest
            // 
            this.btnOldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldest.Location = new System.Drawing.Point(33, 159);
            this.btnOldest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOldest.Name = "btnOldest";
            this.btnOldest.Size = new System.Drawing.Size(226, 39);
            this.btnOldest.TabIndex = 5;
            this.btnOldest.Text = "Oldest Painting";
            this.btnOldest.UseVisualStyleBackColor = true;
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // buttonPaintedBy
            // 
            this.buttonPaintedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaintedBy.Location = new System.Drawing.Point(33, 205);
            this.buttonPaintedBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPaintedBy.Name = "buttonPaintedBy";
            this.buttonPaintedBy.Size = new System.Drawing.Size(226, 39);
            this.buttonPaintedBy.TabIndex = 6;
            this.buttonPaintedBy.Text = "Painted by:";
            this.buttonPaintedBy.UseVisualStyleBackColor = true;
            this.buttonPaintedBy.Click += new System.EventHandler(this.buttonPaintedBy_Click);
            // 
            // textBoxArtistInput
            // 
            this.textBoxArtistInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArtistInput.Location = new System.Drawing.Point(274, 208);
            this.textBoxArtistInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxArtistInput.Name = "textBoxArtistInput";
            this.textBoxArtistInput.Size = new System.Drawing.Size(253, 30);
            this.textBoxArtistInput.TabIndex = 7;
            this.textBoxArtistInput.Text = "Raphael";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(603, 112);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(422, 39);
            this.button7.TabIndex = 8;
            this.button7.Text = "Paintings by Dutch Painters";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(603, 66);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(422, 39);
            this.button8.TabIndex = 9;
            this.button8.Text = "Artists Grouped  by Country";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(603, 205);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(422, 39);
            this.button9.TabIndex = 10;
            this.button9.Text = "Paintings by French or Italian Painters";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnNbyCountry
            // 
            this.btnNbyCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbyCountry.Location = new System.Drawing.Point(603, 20);
            this.btnNbyCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNbyCountry.Name = "btnNbyCountry";
            this.btnNbyCountry.Size = new System.Drawing.Size(422, 39);
            this.btnNbyCountry.TabIndex = 11;
            this.btnNbyCountry.Text = "Number of Paintings from each Country";
            this.btnNbyCountry.UseVisualStyleBackColor = true;
            this.btnNbyCountry.Click += new System.EventHandler(this.btnNbyCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 912);
            this.Controls.Add(this.btnNbyCountry);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxArtistInput);
            this.Controls.Add(this.buttonPaintedBy);
            this.Controls.Add(this.btnOldest);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBefore1800);
            this.Controls.Add(this.btnItaly);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAllPaintings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Art Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllPaintings;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnItaly;
        private System.Windows.Forms.Button btnBefore1800;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOldest;
        private System.Windows.Forms.Button buttonPaintedBy;
        private System.Windows.Forms.TextBox textBoxArtistInput;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnNbyCountry;
    }
}

