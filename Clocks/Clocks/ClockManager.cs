using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogClockControl;

namespace Clocks
{
    public class ClockManager
    {
        // has two clocks
        private IShowTime analog;
        private IShowTime digital;
       
        //initialises clocks
        public ClockManager(Timer timer, Label display, AnalogClock clock)
        {
            digital = new DigitalTimer(timer, display);
            analog = new AnalogTimer(clock);
            digital.ShowClock();
            analog.HideClock();
        }

        //switches clocks based on bool input
        public void ChangeClock(bool isDigital)
        {
            if (isDigital == true)
            {
                digital.ShowClock();
                analog.HideClock();
            }
            else
            {
                analog.ShowClock();
                digital.HideClock();
            }
        }

        //starts clocks
        public void StartClocks()
        {
            digital.StartTime();
            analog.StartTime();
        }

        //stops clocks
        public void StopClocks()
        {
            digital.StopTime();
            analog.StopTime();
        }

        //updates clocks
        public void UpdateClocks()
        {
            digital.UpdateTime();
            analog.UpdateTime();
        }


    }
}
