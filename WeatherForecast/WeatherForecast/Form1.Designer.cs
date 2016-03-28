namespace WeatherForecast
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
            this.buttonUpdateWeather = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.listBoxAverage = new System.Windows.Forms.ListBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.listBoxForecast = new System.Windows.Forms.ListBox();
            this.labelForecast = new System.Windows.Forms.Label();
            this.labelTempInput = new System.Windows.Forms.Label();
            this.labelHumidityInput = new System.Windows.Forms.Label();
            this.labelPressureInput = new System.Windows.Forms.Label();
            this.textBoxTempInput = new System.Windows.Forms.TextBox();
            this.textBoxHumidityInput = new System.Windows.Forms.TextBox();
            this.textBoxPressureInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUpdateWeather
            // 
            this.buttonUpdateWeather.Location = new System.Drawing.Point(60, 87);
            this.buttonUpdateWeather.Name = "buttonUpdateWeather";
            this.buttonUpdateWeather.Size = new System.Drawing.Size(205, 64);
            this.buttonUpdateWeather.TabIndex = 0;
            this.buttonUpdateWeather.Text = "Update Measurements";
            this.buttonUpdateWeather.UseVisualStyleBackColor = true;
            this.buttonUpdateWeather.Click += new System.EventHandler(this.buttonUpdateWeather_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(508, 86);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(125, 20);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "Temperature (C)";
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.ItemHeight = 20;
            this.listBoxTemp.Location = new System.Drawing.Point(512, 130);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(354, 104);
            this.listBoxTemp.TabIndex = 2;
            // 
            // listBoxAverage
            // 
            this.listBoxAverage.FormattingEnabled = true;
            this.listBoxAverage.ItemHeight = 20;
            this.listBoxAverage.Location = new System.Drawing.Point(512, 303);
            this.listBoxAverage.Name = "listBoxAverage";
            this.listBoxAverage.Size = new System.Drawing.Size(354, 104);
            this.listBoxAverage.TabIndex = 4;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(508, 259);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(140, 20);
            this.labelAverage.TabIndex = 3;
            this.labelAverage.Text = "Average Readings";
            // 
            // listBoxForecast
            // 
            this.listBoxForecast.FormattingEnabled = true;
            this.listBoxForecast.ItemHeight = 20;
            this.listBoxForecast.Location = new System.Drawing.Point(512, 475);
            this.listBoxForecast.Name = "listBoxForecast";
            this.listBoxForecast.Size = new System.Drawing.Size(354, 104);
            this.listBoxForecast.TabIndex = 6;
            // 
            // labelForecast
            // 
            this.labelForecast.AutoSize = true;
            this.labelForecast.Location = new System.Drawing.Point(508, 431);
            this.labelForecast.Name = "labelForecast";
            this.labelForecast.Size = new System.Drawing.Size(72, 20);
            this.labelForecast.TabIndex = 5;
            this.labelForecast.Text = "Forecast";
            // 
            // labelTempInput
            // 
            this.labelTempInput.AutoSize = true;
            this.labelTempInput.Location = new System.Drawing.Point(56, 246);
            this.labelTempInput.Name = "labelTempInput";
            this.labelTempInput.Size = new System.Drawing.Size(125, 20);
            this.labelTempInput.TabIndex = 7;
            this.labelTempInput.Text = "Temperature (C)";
            // 
            // labelHumidityInput
            // 
            this.labelHumidityInput.AutoSize = true;
            this.labelHumidityInput.Location = new System.Drawing.Point(56, 336);
            this.labelHumidityInput.Name = "labelHumidityInput";
            this.labelHumidityInput.Size = new System.Drawing.Size(98, 20);
            this.labelHumidityInput.TabIndex = 8;
            this.labelHumidityInput.Text = "Humidity (%)";
            // 
            // labelPressureInput
            // 
            this.labelPressureInput.AutoSize = true;
            this.labelPressureInput.Location = new System.Drawing.Point(56, 431);
            this.labelPressureInput.Name = "labelPressureInput";
            this.labelPressureInput.Size = new System.Drawing.Size(153, 20);
            this.labelPressureInput.TabIndex = 9;
            this.labelPressureInput.Text = "Barometric Pressure";
            // 
            // textBoxTempInput
            // 
            this.textBoxTempInput.Location = new System.Drawing.Point(60, 288);
            this.textBoxTempInput.Name = "textBoxTempInput";
            this.textBoxTempInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxTempInput.TabIndex = 10;
            // 
            // textBoxHumidityInput
            // 
            this.textBoxHumidityInput.Location = new System.Drawing.Point(60, 381);
            this.textBoxHumidityInput.Name = "textBoxHumidityInput";
            this.textBoxHumidityInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxHumidityInput.TabIndex = 11;
            // 
            // textBoxPressureInput
            // 
            this.textBoxPressureInput.Location = new System.Drawing.Point(60, 475);
            this.textBoxPressureInput.Name = "textBoxPressureInput";
            this.textBoxPressureInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxPressureInput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 610);
            this.Controls.Add(this.textBoxPressureInput);
            this.Controls.Add(this.textBoxHumidityInput);
            this.Controls.Add(this.textBoxTempInput);
            this.Controls.Add(this.labelPressureInput);
            this.Controls.Add(this.labelHumidityInput);
            this.Controls.Add(this.labelTempInput);
            this.Controls.Add(this.listBoxForecast);
            this.Controls.Add(this.labelForecast);
            this.Controls.Add(this.listBoxAverage);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.buttonUpdateWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateWeather;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.ListBox listBoxAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.ListBox listBoxForecast;
        private System.Windows.Forms.Label labelForecast;
        private System.Windows.Forms.Label labelTempInput;
        private System.Windows.Forms.Label labelHumidityInput;
        private System.Windows.Forms.Label labelPressureInput;
        private System.Windows.Forms.TextBox textBoxTempInput;
        private System.Windows.Forms.TextBox textBoxHumidityInput;
        private System.Windows.Forms.TextBox textBoxPressureInput;
    }
}

