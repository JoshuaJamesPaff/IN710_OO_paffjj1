using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarUsingEventHandler
{
    public abstract class Observer
    {
        //observer has subject instance and a name
        protected SubjectWithEvent subject;

        //sets subject, button, random object
        public Observer(SubjectWithEvent subject)
        {
            this.subject = subject;

            //adds delegate instance containing "DoStuff" to the buttons click event 
            subject.OnProgressUpdateEvent += new System.EventHandler(DoStuff);
        }

        //method to be delegated updates progress
        public abstract void DoStuff(Object o, EventArgs data);
    }
}
