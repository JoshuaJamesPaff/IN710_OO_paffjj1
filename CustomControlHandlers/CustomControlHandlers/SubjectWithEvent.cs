using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlHandlers
{
    public class SubjectWithEvent
    { 
        //declares a delegate and an event of same type as delegate
        public delegate void EventHandlerDelegateWithData(Object o, EventArgs eventData);
        public event EventHandlerDelegateWithData EventWithData;

        //raise event and send Event args
        public void OnRaiseEvent()
        {
            //event args object
            EventArgs data = new EventArgs();

            //if event has "observers"  then pass it EventArgs object (custom data) and call delegated method
            if (EventWithData != null)
            {
                EventWithData(this, data);
            }
                
        }

    }
}
