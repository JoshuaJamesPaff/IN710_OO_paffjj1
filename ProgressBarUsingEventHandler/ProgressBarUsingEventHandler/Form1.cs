using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarUsingEventHandler
{
    public partial class Form1 : Form
    {

        private SubjectWithEvent progressSubject;
        private SpinBoxObserver obsSpin;
        private ProgressBarObserver obsProgress;
        private TrackBarObserver obsTrack;

        public Form1()
        {
            InitializeComponent();

            progressSubject = new SubjectWithEvent();

            //creates observers - spinbox takes in form control
            obsSpin = new SpinBoxObserver(progressSubject, spinBox, this);
            obsProgress = new ProgressBarObserver(progressSubject, progressBar);
            obsTrack = new TrackBarObserver(progressSubject, trackBar);

            
        }

        //raises the event in the subject then resets values when done
        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            progressSubject.SlowMethod();

            //waits then resets values
            System.Threading.Thread.Sleep(500);
            ResetValues();
        }

        //sets values to 0
        private void ResetValues()
        {
            trackBar.Value = 0;
            spinBox.Value = 0;
            progressBar.Value = 0;

        }

    }
}
