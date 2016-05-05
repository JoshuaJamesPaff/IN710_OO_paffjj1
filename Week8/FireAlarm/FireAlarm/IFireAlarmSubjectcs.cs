using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public interface IFireAlarmSubject
    {
        //requires 
        void OnFire(EFireLevel fireSeriousness);
    }
}
