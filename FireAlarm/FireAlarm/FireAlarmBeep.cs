using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    //child of observer, overides handler method to make a beep
    public class FireAlarmBeep : FireAlarmObserver
    {
        // beep method
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public FireAlarmBeep(FireAlarmSubject subject)
            : base(subject)
        {
        }

        public override void FireAlarmHandler(Object o, FireAlarmType e)
        {
            int frequency;

            switch (e.FireLvl)
            {
                case EFireLevel.MINOR:
                    frequency = 332;
                    break;

                case EFireLevel.SERIOUS:
                    frequency = 432;
                    break;

                case EFireLevel.INFERNO:
                    frequency = 666;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            //beeps at set freq 5 times
            Beep(frequency, 300);
            System.Threading.Thread.Sleep(100);
            Beep(frequency, 300);
            System.Threading.Thread.Sleep(100);
            Beep(frequency, 300);
            System.Threading.Thread.Sleep(100);
            Beep(frequency, 300);
            System.Threading.Thread.Sleep(100);
            Beep(frequency, 300);
        }
    }
}
