using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarUsingEventHandler
{
    public class TrackBarObserver : Observer
    {
        private TrackBar trackBar;

        public TrackBarObserver(SubjectWithEvent subject, TrackBar admiralTrackBar)
            : base(subject)
        {
            trackBar = admiralTrackBar;
        }

        public override void DoStuff(object o, EventArgs data)
        {
            trackBar.Value++;

        }
    }
}
