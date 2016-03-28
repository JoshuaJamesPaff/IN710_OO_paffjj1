using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeDashBoard
{
    public class ObserverRPMDisplay : ObserverDisplay
    {
        public ObserverRPMDisplay(SubjectSpeedMonitor bikeMonitor, Label displayLabel)
            :base(bikeMonitor, displayLabel)
        {
            
        }

        //computes rpm
        public override void ComputeData()
        {
            currentComputedValue = currentSpeed;
        }
    }
}
