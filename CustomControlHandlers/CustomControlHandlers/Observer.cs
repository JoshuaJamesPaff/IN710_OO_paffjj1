using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public class Observer
    {
        //observer has subject instance and a name
        private SubjectWithEvent subject;
        private String observerName;
        private Random random;
        private String buttonString;
        
        //sets subject, button, random object
        public Observer(SubjectWithEvent subject, String observerName, Button buttonToClick, Random random)
        {
            this.subject = subject;
            this.observerName = observerName;
            this.random = random;
            buttonString = buttonToClick.ToString();

            //adds delegate instance containing "DoStuff" to the buttons click event 
            buttonToClick.Click += new System.EventHandler(DoStuff); 
        }

        //sets up data for message box
        public String MessageShow()
        {
            int codeNumber = random.Next(1, 1000);
            String message = "This is a custom handler whose code number is " + codeNumber + " and button is " + buttonString + ".";
            return message;
        }

        //method to be delegated takes event arguments and prints out data to message box
        public void DoStuff(Object o, EventArgs data)
        {
            MessageBox.Show(MessageShow());
        }
    }
}
