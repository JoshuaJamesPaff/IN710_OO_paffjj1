using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public class DisplayTemperature : WeatherDisplay
    {
        public DisplayTemperature(IWeatherSubject subject, ListBox output)
            :base(subject, output)
        { 
        }

        //changes values and displays them
        public override void Update(int temp, int humidity, int pressure)
        {
            CurrentTemp = temp;
            CurrentHumidity = humidity;
            CurrentPressure = pressure;

            Display();
        }
    }
}
