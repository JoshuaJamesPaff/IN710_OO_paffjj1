using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeDashBoard
{
    public class ObserverVelocityDisplay : ObserverDisplay
    {
        public ObserverVelocityDisplay(SubjectSpeedMonitor bikeMonitor, Label displayLabel)
            :base(bikeMonitor, displayLabel)
        {
            
        }

        //computes velocity
        public override void ComputeData()
        {
            double wheelCircumferenceMetres = 2.05;
            double RPH = currentSpeed * 60;
            currentComputedValue = (RPH * wheelCircumferenceMetres) / 1000;

        }
    }
}
