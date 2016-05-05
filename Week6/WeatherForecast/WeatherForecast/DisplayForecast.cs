using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public class DisplayForecast : WeatherDisplay
    {
        //default forecast text
        private string forecast = "Unable to get forecast at this time.";

        public DisplayForecast(IWeatherSubject subject, ListBox output)
            :base(subject, output)
        { 
        }

        //overides display method
        public override void Display(){

            //only displays forcast string
            output.Items.Clear();
            output.Items.Add(forecast);
           
        }

        //calculates forecast and outputs it
        public override void Update(int temp, int humidity, int pressure)
        {
            //temp
            if (temp > CurrentTemp)
            {
                forecast = "Getting warmer ";
            }
            else
            {
                forecast = "Getting colder ";
            }

            //humidity
            if (humidity > CurrentHumidity)
            {
                forecast += "and muggier, ";
            }
            else
            {
                forecast += "but briskier, ";
            }

            //pressure
            if (pressure > CurrentPressure)
            {
                forecast += "showers expected later.";
            }
            else
            {
                forecast += "with the skies expected to clear up.";
            }

            CurrentTemp = temp;
            CurrentHumidity = humidity;
            CurrentPressure = pressure;

            Display();
        }
    }
}
