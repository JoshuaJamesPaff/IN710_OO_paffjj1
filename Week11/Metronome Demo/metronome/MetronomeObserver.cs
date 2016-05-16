using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    // delegate to change form controls (each observer needs a method wit hthe same sig)
    public delegate void FormControlDelegate(metronomeEventArgs args);

    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.spinBox.InvokeRequired)
            {
                FormControlDelegate updateControl = new FormControlDelegate(increaseSpinBox);
                spinBox.Invoke(updateControl, new object[] { e });
            }
            else
            {
                increaseSpinBox(e);
            }

        }

        //method changes spinbox (method matches FormControlDelegate signature)
        public void increaseSpinBox(metronomeEventArgs e)
        {
            spinBox.Value++;
        }

    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.listBox.InvokeRequired)
            {
                FormControlDelegate updateControl = new FormControlDelegate(updateListBox);
                listBox.Invoke(updateControl, new object[] { e });
            }
            else
            {
                updateListBox(e);
            }

        }

        //method gets time from metronome event object and sets it to listbox (method matches FormControlDelegate signature)
        public void updateListBox(metronomeEventArgs e)
        {
            DateTime dateTime = e.currentTime;
            listBox.Items.Add(dateTime.ToString());
        }
    }






            
}
