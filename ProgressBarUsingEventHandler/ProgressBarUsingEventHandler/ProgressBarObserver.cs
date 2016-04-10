using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarUsingEventHandler
{
    public class ProgressBarObserver : Observer
    {
        private ProgressBar progressBar;

        public ProgressBarObserver(SubjectWithEvent subject, ProgressBar pb) 
            : base(subject)
        {
            progressBar = pb;
        }

        public override void DoStuff(object o, EventArgs data)
        {
            progressBar.PerformStep();
               
        }
    }
}
