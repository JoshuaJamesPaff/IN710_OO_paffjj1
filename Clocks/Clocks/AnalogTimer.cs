using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalogClockControl;

namespace Clocks
{
    public class AnalogTimer : IShowTime
    {
        private AnalogClock clock;
        private DateTime currentTime;

        public AnalogTimer(AnalogClock clock)
        {
            currentTime = DateTime.Now;
            this.clock = clock;
            
        }

        public void StartTime()
        {
            clock.Start();
        }

        public void StopTime()
        {
            clock.Stop();
        }

        public void HideClock()
        {
            clock.Hide();
        }

        public void ShowClock()
        {
            clock.Show();
        }


        public void UpdateTime()
        {
            clock.Start();
        }
    }
}
