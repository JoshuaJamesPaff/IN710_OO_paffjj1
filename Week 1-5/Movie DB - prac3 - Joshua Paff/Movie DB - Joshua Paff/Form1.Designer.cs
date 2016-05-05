namespace Movie_DB___Joshua_Paff
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
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.labelAddMovieYear = new System.Windows.Forms.Label();
            this.labelAddMovieDirector = new System.Windows.Forms.Label();
            this.labelAddMovieTitle = new System.Windows.Forms.Label();
            this.labelDeleteMovieYear = new System.Windows.Forms.Label();
            this.labelSearchMovieYear = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPrintAll = new System.Windows.Forms.Button();
            this.textBoxAddYear = new System.Windows.Forms.TextBox();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.textBoxAddDirector = new System.Windows.Forms.TextBox();
            this.textBoxDeleteYear = new System.Windows.Forms.TextBox();
            this.textBoxSearchYear = new System.Windows.Forms.TextBox();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(72, 89);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(109, 41);
            this.buttonAddMovie.TabIndex = 0;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(72, 316);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(109, 55);
            this.buttonDeleteMovie.TabIndex = 1;
            this.buttonDeleteMovie.Text = "Delete Movie";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // labelAddMovieYear
            // 
            this.labelAddMovieYear.AutoSize = true;
            this.labelAddMovieYear.Location = new System.Drawing.Point(234, 99);
            this.labelAddMovieYear.Name = "labelAddMovieYear";
            this.labelAddMovieYear.Size = new System.Drawing.Size(47, 20);
            this.labelAddMovieYear.TabIndex = 2;
            this.labelAddMovieYear.Text = "Year:";
            // 
            // labelAddMovieDirector
            // 
            this.labelAddMovieDirector.AutoSize = true;
            this.labelAddMovieDirector.Location = new System.Drawing.Point(234, 180);
            this.labelAddMovieDirector.Name = "labelAddMovieDirector";
            this.labelAddMovieDirector.Size = new System.Drawing.Size(69, 20);
            this.labelAddMovieDirector.TabIndex = 3;
            this.labelAddMovieDirector.Text = "Director:";
            // 
            // labelAddMovieTitle
            // 
            this.labelAddMovieTitle.AutoSize = true;
            this.labelAddMovieTitle.Location = new System.Drawing.Point(234, 140);
            this.labelAddMovieTitle.Name = "labelAddMovieTitle";
            this.labelAddMovieTitle.Size = new System.Drawing.Size(42, 20);
            this.labelAddMovieTitle.TabIndex = 4;
            this.labelAddMovieTitle.Text = "Title:";
            // 
            // labelDeleteMovieYear
            // 
            this.labelDeleteMovieYear.AutoSize = true;
            this.labelDeleteMovieYear.Location = new System.Drawing.Point(234, 333);
            this.labelDeleteMovieYear.Name = "labelDeleteMovieYear";
            this.labelDeleteMovieYear.Size = new System.Drawing.Size(47, 20);
            this.labelDeleteMovieYear.TabIndex = 5;
            this.labelDeleteMovieYear.Text = "Year:";
            // 
            // labelSearchMovieYear
            // 
            this.labelSearchMovieYear.AutoSize = true;
            this.labelSearchMovieYear.Location = new System.Drawing.Point(234, 453);
            this.labelSearchMovieYear.Name = "labelSearchMovieYear";
            this.labelSearchMovieYear.Size = new System.Drawing.Size(47, 20);
            this.labelSearchMovieYear.TabIndex = 6;
            this.labelSearchMovieYear.Text = "Year:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(72, 436);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(109, 55);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPrintAll
            // 
            this.buttonPrintAll.Location = new System.Drawing.Point(72, 542);
            this.buttonPrintAll.Name = "buttonPrintAll";
            this.buttonPrintAll.Size = new System.Drawing.Size(109, 55);
            this.buttonPrintAll.TabIndex = 8;
            this.buttonPrintAll.Text = "Print All";
            this.buttonPrintAll.UseVisualStyleBackColor = true;
            this.buttonPrintAll.Click += new System.EventHandler(this.buttonPrintAll_Click);
            // 
            // textBoxAddYear
            // 
            this.textBoxAddYear.Location = new System.Drawing.Point(335, 99);
            this.textBoxAddYear.Name = "textBoxAddYear";
            this.textBoxAddYear.Size = new System.Drawing.Size(182, 26);
            this.textBoxAddYear.TabIndex = 10;
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Location = new System.Drawing.Point(335, 140);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(182, 26);
            this.textBoxAddTitle.TabIndex = 11;
            // 
            // textBoxAddDirector
            // 
            this.textBoxAddDirector.Location = new System.Drawing.Point(335, 180);
            this.textBoxAddDirector.Name = "textBoxAddDirector";
            this.textBoxAddDirector.Size = new System.Drawing.Size(182, 26);
            this.textBoxAddDirector.TabIndex = 12;
            // 
            // textBoxDeleteYear
            // 
            this.textBoxDeleteYear.Location = new System.Drawing.Point(335, 333);
            this.textBoxDeleteYear.Name = "textBoxDeleteYear";
            this.textBoxDeleteYear.Size = new System.Drawing.Size(182, 26);
            this.textBoxDeleteYear.TabIndex = 13;
            // 
            // textBoxSearchYear
            // 
            this.textBoxSearchYear.Location = new System.Drawing.Point(331, 458);
            this.textBoxSearchYear.Name = "textBoxSearchYear";
            this.textBoxSearchYear.Size = new System.Drawing.Size(182, 26);
            this.textBoxSearchYear.TabIndex = 14;
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 20;
            this.listBoxMovies.Location = new System.Drawing.Point(259, 542);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(333, 284);
            this.listBoxMovies.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 863);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.textBoxSearchYear);
            this.Controls.Add(this.textBoxDeleteYear);
            this.Controls.Add(this.textBoxAddDirector);
            this.Controls.Add(this.textBoxAddTitle);
            this.Controls.Add(this.textBoxAddYear);
            this.Controls.Add(this.buttonPrintAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchMovieYear);
            this.Controls.Add(this.labelDeleteMovieYear);
            this.Controls.Add(this.labelAddMovieTitle);
            this.Controls.Add(this.labelAddMovieDirector);
            this.Controls.Add(this.labelAddMovieYear);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label labelAddMovieYear;
        private System.Windows.Forms.Label labelAddMovieDirector;
        private System.Windows.Forms.Label labelAddMovieTitle;
        private System.Windows.Forms.Label labelDeleteMovieYear;
        private System.Windows.Forms.Label labelSearchMovieYear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPrintAll;
        private System.Windows.Forms.TextBox textBoxAddYear;
        private System.Windows.Forms.TextBox textBoxAddTitle;
        private System.Windows.Forms.TextBox textBoxAddDirector;
        private System.Windows.Forms.TextBox textBoxDeleteYear;
        private System.Windows.Forms.TextBox textBoxSearchYear;
        private System.Windows.Forms.ListBox listBoxMovies;
    }
}

