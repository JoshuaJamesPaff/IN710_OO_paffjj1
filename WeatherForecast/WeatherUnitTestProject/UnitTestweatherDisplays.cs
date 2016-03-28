using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherForecast;
using System.Windows.Forms;

namespace WeatherUnitTestProject
{
    [TestClass]
    public class UnitTestWeatherDisplays
    {
        public ListBox testOutput = new ListBox();
        public WeatherMonitor weatherSubject = new WeatherMonitor();
        //DisplayAverage averageObserver = new DisplayAverage(weatherSubject, testOutput);
        //

        [TestMethod]
        public void UpdateTemp_OutputsCorrectString()
        {
            DisplayTemperature temperatureObserver = new DisplayTemperature(weatherSubject, testOutput);
            
            weatherSubject.NotifyObservers(1, 2, 3);
            string expectedTemp = "1";

            string actual = (string)testOutput.Items[0];

            Assert.AreEqual(expectedTemp, actual, "Temp observer updates and prints correctly");
            
        }

        [TestMethod]
        public void UpdateForecast_OutputsCorrectString()
        {
            DisplayForecast forecastObserver = new DisplayForecast(weatherSubject, testOutput);

            weatherSubject.NotifyObservers(1, 2, 3);
            weatherSubject.NotifyObservers(2, 3, 4);
            string expectedForecast = "Getting warmer "+"and muggier, "+"showers expected later.";

            string actual = (string)testOutput.Items[0];

            Assert.AreEqual(expectedForecast, actual, "Forecast observer updates and prints correctly");
            
        }

        [TestMethod]
        public void UpdateAverage_OutputsCorrectString()
        {
            DisplayAverage averageObserver = new DisplayAverage(weatherSubject, testOutput);

            weatherSubject.NotifyObservers(1, 1, 1);
            weatherSubject.NotifyObservers(3, 3, 3);
            string expectedAverageTemp = "2";

            string actual = (string)testOutput.Items[0];

            Assert.AreEqual(expectedAverageTemp, actual, "Average observer updates and prints correctly");

        }
    }
}
