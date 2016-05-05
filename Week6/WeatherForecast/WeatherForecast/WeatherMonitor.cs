using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class WeatherMonitor : IWeatherSubject
    {
        // has a list of observers and methods to edit that list
        private List<IWeatherObserver> observerList;

        public WeatherMonitor()
        {
            observerList = new List<IWeatherObserver>();
        }

        public void AddObserver(IWeatherObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObservers(int temp, int humidity, int pressure)
        {
            foreach (IWeatherObserver obv in observerList)
            {
                //updates observers based on speed property and displays their output value
                obv.Update(temp, humidity, pressure);
            }
        }
    }
}
