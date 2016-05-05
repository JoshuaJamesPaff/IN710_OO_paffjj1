using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    //child of observer, overides handler method to display message
    public class FireAlarmMessage : FireAlarmObserver
    {
        public FireAlarmMessage(FireAlarmSubject subject)
            : base(subject)
        {
        }

        public override void FireAlarmHandler(Object o, FireAlarmType e)
        {

            String output = "This ";

            switch (e.FireLvl)
            {
                case EFireLevel.MINOR:
                    output += "fire is minor, it will go out on its own.";
                    break;

                case EFireLevel.SERIOUS:
                    output += "fire is serious, call the Ambalamps";
                    break;

                case EFireLevel.INFERNO:
                    output += "fire is blazing out of control!";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            //shows the set message
            MessageBox.Show(output);
        }
    }
}
