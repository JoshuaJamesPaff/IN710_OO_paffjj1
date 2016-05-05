using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserver
    {
        protected FireAlarmSubject subject;

        public FireAlarmObserver(FireAlarmSubject subject)
        {
            this.subject = subject;

            // Add the Fire Alarm Handler to the list of handlers for Subject.FireEvent
            subject.feHandler += new FireAlarmSubject.FireEventHandler(FireAlarmHandler);
        }

        public abstract void FireAlarmHandler(Object o, FireAlarmType fireEvent);
    }
}
