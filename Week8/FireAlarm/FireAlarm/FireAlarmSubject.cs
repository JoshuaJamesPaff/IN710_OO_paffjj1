using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class FireAlarmSubject : IFireAlarmSubject
    {
        //declares a delegate and an event of same type
        public delegate void FireEventHandler(Object o, FireAlarmType fe);
        public event FireEventHandler feHandler;

        //on fire takes a firelevel as argument and
        public void OnFire(EFireLevel fireLvl)
        {
            FireAlarmType fireEvent = new FireAlarmType(fireLvl);

            if (feHandler != null)
                feHandler(this, fireEvent);
        }
    }
}
