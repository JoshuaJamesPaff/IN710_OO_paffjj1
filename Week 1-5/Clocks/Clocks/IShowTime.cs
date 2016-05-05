using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{

    
    interface IShowTime
    {
        void StartTime();
        void StopTime();
        void HideClock();
        void ShowClock();
        void UpdateTime();
    }
}
