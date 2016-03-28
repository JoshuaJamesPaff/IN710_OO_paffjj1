using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public interface IWeatherObserver
    {
        void Update(int temp, int humidity, int pressure);
        void Display(); 
    }
}
