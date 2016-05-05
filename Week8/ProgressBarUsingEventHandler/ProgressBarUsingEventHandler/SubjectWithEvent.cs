using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarUsingEventHandler
{
    public class SubjectWithEvent
    {

        //declares an event using system eventhandler class
        public event EventHandler OnProgressUpdateEvent;


        //calls the event raise 10 times
        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(550);
                OnProgressUpdateEvent(this, new EventArgs());
                
               
            }
        }

    }
}