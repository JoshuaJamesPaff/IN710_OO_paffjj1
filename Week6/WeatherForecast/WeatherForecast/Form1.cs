using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form1 : Form
    {
        private WeatherMonitor weatherSubject;
        private DisplayAverage averageObserver;
        private DisplayForecast forecastObserver;
        private DisplayTemperature temperatureObserver;

        public Form1()
        {
            InitializeComponent();

            //creates subject and observers and sets their listboxes
            weatherSubject = new WeatherMonitor();
            averageObserver = new DisplayAverage(weatherSubject, listBoxAverage);
            forecastObserver = new DisplayForecast(weatherSubject, listBoxForecast);
            temperatureObserver = new DisplayTemperature(weatherSubject, listBoxTemp);
        }

        private void buttonUpdateWeather_Click(object sender, EventArgs e)
        {
            //assigns default of 0 if input is not numeral
            int temp = 0;
            int humidity = 0;
            int pressure = 0;
            int test;

            //checks that numbers have been entered
            if (int.TryParse(textBoxTempInput.Text, out test)) temp = Int32.Parse(textBoxTempInput.Text);
            if (int.TryParse(textBoxHumidityInput.Text, out test)) humidity = Int32.Parse(textBoxHumidityInput.Text);
            if (int.TryParse(textBoxPressureInput.Text, out test)) pressure = Int32.Parse(textBoxPressureInput.Text);

            //updates subject
            weatherSubject.NotifyObservers(temp, humidity, pressure);
        }
    }
}
