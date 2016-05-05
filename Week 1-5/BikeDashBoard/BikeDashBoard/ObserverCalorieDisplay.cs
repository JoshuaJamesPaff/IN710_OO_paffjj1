using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeDashBoard
{
    public class ObserverCalorieDisplay : ObserverDisplay
    {
        public ObserverCalorieDisplay(SubjectSpeedMonitor bikeMonitor, Label displayLabel)
            :base(bikeMonitor, displayLabel)
        {
            
        }

        //computes calories
        public override void ComputeData()
        {
            currentComputedValue = 5 * currentSpeed;
        }
    }
}
