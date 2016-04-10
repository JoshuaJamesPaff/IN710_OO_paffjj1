using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarUsingEventHandler
{
    public class SpinBoxObserver : Observer
    {
        private NumericUpDown spinBox;

        //object to update form
        private Form formControl;

        public SpinBoxObserver(SubjectWithEvent subject, NumericUpDown spinBox, Form form)
            : base(subject)
        {
            this.spinBox = spinBox;

            //sets form
            formControl = form;
        }

        public override void DoStuff(object o, EventArgs data)
        {
            spinBox.Value++;
            formControl.Refresh();

        }
    }
}
