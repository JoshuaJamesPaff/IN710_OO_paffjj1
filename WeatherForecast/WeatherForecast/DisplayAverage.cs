using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public class DisplayAverage : WeatherDisplay
    {
        public DisplayAverage(IWeatherSubject subject, ListBox output)
            :base(subject, output)
        { 
        }

        //averages values and displays them
        public override void Update(int temp, int humidity, int pressure)
        {
            CurrentTemp = (temp + CurrentTemp)/2;
            CurrentHumidity = (humidity + CurrentHumidity)/2;
            CurrentPressure = (pressure + CurrentPressure)/2;

            Display();
        }
    }
}
