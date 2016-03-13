using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        //manager object
        private ClockManager manager;

        //gives manager a clock, timer and a label
        public Form1()
        {
            InitializeComponent();
            manager = new ClockManager(timerDigitalClock, labelDigitalClock, analogClock);
        }

        //updates clocks
        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            manager.UpdateClocks();
        }

        //starts clocks
        private void buttonStart_Click(object sender, EventArgs e)
        {
            manager.StartClocks();
        }

        //stops clocks
        private void buttonStop_Click(object sender, EventArgs e)
        {
            manager.StopClocks();
        }

        //if radio button is changed clock changes
        private void radioButtonDigital_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDigital.Checked == true)
            {
                manager.ChangeClock(true);
            }
            else {
                manager.ChangeClock(false); 
            }
        }


        //useless methods that i cant delete without corrupting project
        private void groupBoxClockType_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonAnalog_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
