using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeDashBoard
{
    public abstract class ObserverDisplay : IObserver
    {
        protected int currentSpeed;
        protected double currentComputedValue;
        protected Label displayLabel;

        //constructor sets default subject and Label to display to
        public ObserverDisplay(SubjectSpeedMonitor bikeMonitor, Label displayLabel)
        {
            this.displayLabel = displayLabel;

            //adds observer to monitor
            bikeMonitor.AddObserver(this);
        }

        //abstract method for computing data
        public abstract void ComputeData();

        //displays computed value to label
        public void Display()
        {
            displayLabel.Text = currentComputedValue + "";
        }


        //sets current speed and displays computed value
        public void Update(int data)
        {
            currentSpeed = data;
            ComputeData();
            Display();
        }

        
    }
}
