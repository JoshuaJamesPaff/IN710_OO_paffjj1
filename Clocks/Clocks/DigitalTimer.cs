using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public class DigitalTimer : IShowTime
    {
        //has properties to hold the time, timer and label to display time
        private Timer digitalTimer;
        private Label digitalDisplay;
        private DateTime currentTime;

        public DigitalTimer(Timer digitalTimer, Label digitalDisplay){

            currentTime = DateTime.Now;
            this.digitalTimer = digitalTimer;
            this.digitalDisplay = digitalDisplay;
            

        }
        //starts timer
        public void StartTime()
        {
            digitalTimer.Start();
        }

        //stops timer
        public void StopTime()
        {
            digitalTimer.Stop();
        }

        //hides label
        public void HideClock()
        {
            digitalDisplay.Hide();
        }

        //shows label
        public void ShowClock()
        {
            digitalDisplay.Show();
        }


        public void UpdateTime()
        {
            currentTime = DateTime.Now;
            digitalDisplay.Text = currentTime.ToLongTimeString();
        }
    }
}
