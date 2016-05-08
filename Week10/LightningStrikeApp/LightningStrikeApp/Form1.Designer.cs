namespace LightningStrikeApp
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
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.buttonAvgIntensity = new System.Windows.Forms.Button();
            this.buttonThreeFires = new System.Windows.Forms.Button();
            this.buttonLatLong = new System.Windows.Forms.Button();
            this.buttonFiresByLightning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 20;
            this.listBoxDisplay.Location = new System.Drawing.Point(352, 29);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(873, 504);
            this.listBoxDisplay.TabIndex = 0;
            // 
            // buttonAvgIntensity
            // 
            this.buttonAvgIntensity.Location = new System.Drawing.Point(26, 29);
            this.buttonAvgIntensity.Name = "buttonAvgIntensity";
            this.buttonAvgIntensity.Size = new System.Drawing.Size(267, 40);
            this.buttonAvgIntensity.TabIndex = 1;
            this.buttonAvgIntensity.Text = "Average Lightning Intensity";
            this.buttonAvgIntensity.UseVisualStyleBackColor = true;
            this.buttonAvgIntensity.Click += new System.EventHandler(this.buttonAvgIntensity_Click);
            // 
            // buttonThreeFires
            // 
            this.buttonThreeFires.Location = new System.Drawing.Point(26, 93);
            this.buttonThreeFires.Name = "buttonThreeFires";
            this.buttonThreeFires.Size = new System.Drawing.Size(267, 40);
            this.buttonThreeFires.TabIndex = 2;
            this.buttonThreeFires.Text = "Largest 3 Fires";
            this.buttonThreeFires.UseVisualStyleBackColor = true;
            this.buttonThreeFires.Click += new System.EventHandler(this.buttonThreeFires_Click);
            // 
            // buttonLatLong
            // 
            this.buttonLatLong.Location = new System.Drawing.Point(26, 157);
            this.buttonLatLong.Name = "buttonLatLong";
            this.buttonLatLong.Size = new System.Drawing.Size(267, 40);
            this.buttonLatLong.TabIndex = 3;
            this.buttonLatLong.Text = "Latitude and Longitudes";
            this.buttonLatLong.UseVisualStyleBackColor = true;
            this.buttonLatLong.Click += new System.EventHandler(this.buttonLatLong_Click);
            // 
            // buttonFiresByLightning
            // 
            this.buttonFiresByLightning.Location = new System.Drawing.Point(26, 217);
            this.buttonFiresByLightning.Name = "buttonFiresByLightning";
            this.buttonFiresByLightning.Size = new System.Drawing.Size(267, 40);
            this.buttonFiresByLightning.TabIndex = 4;
            this.buttonFiresByLightning.Text = "Fires Caused by Lightning";
            this.buttonFiresByLightning.UseVisualStyleBackColor = true;
            this.buttonFiresByLightning.Click += new System.EventHandler(this.buttonFiresByLightning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 624);
            this.Controls.Add(this.buttonFiresByLightning);
            this.Controls.Add(this.buttonLatLong);
            this.Controls.Add(this.buttonThreeFires);
            this.Controls.Add(this.buttonAvgIntensity);
            this.Controls.Add(this.listBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button buttonAvgIntensity;
        private System.Windows.Forms.Button buttonThreeFires;
        private System.Windows.Forms.Button buttonLatLong;
        private System.Windows.Forms.Button buttonFiresByLightning;
    }
}

