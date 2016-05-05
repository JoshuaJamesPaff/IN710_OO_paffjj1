using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public abstract class WeatherDisplay : IWeatherObserver
    {
        private int currentTemp;
        private int currentHumidity;
        private int currentPressure;
        
        protected ListBox output;

        //constructor sets default subject and output
        public WeatherDisplay(IWeatherSubject subject, ListBox output)
        {
            this.output = output;

            //adds observer to monitor
            subject.AddObserver(this);

            //sets values to 0
            currentHumidity = 0;
            currentPressure = 0;
            currentTemp = 0;
        }


        //displays computed value to label
        public virtual void Display()
        {
            output.Items.Clear();
            output.Items.Add(currentTemp + "");
            output.Items.Add(currentHumidity + "");
            output.Items.Add(currentPressure + "");
        }

        //sets current speed and displays computed value
        public abstract void Update(int temp, int humidity, int pressure);

        // getter/setters
        protected int CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        protected int CurrentHumidity
        {
            get { return currentHumidity; }
            set { currentHumidity = value; }
        }

        protected int CurrentPressure
        {
            get { return currentPressure; }
            set { currentPressure = value; }
        }
    }
}
