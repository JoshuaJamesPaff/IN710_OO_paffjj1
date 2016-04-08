using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    //class that stores current enum and returns it
    public class FireAlarmType : EventArgs
    {
        private EFireLevel fireLvl;

        public FireAlarmType(EFireLevel fireLvl)
        {
            this.fireLvl = fireLvl;
        }

        //sets gets fire lvl
        public EFireLevel FireLvl
        {
            get { return fireLvl; }
            set { fireLvl = value; }
        }
    }
}
