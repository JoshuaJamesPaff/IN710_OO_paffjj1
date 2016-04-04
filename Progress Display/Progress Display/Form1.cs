using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //delegate for update methods
        public delegate void FeedbackDelegate();

        //click handler creates delegate and assigns it based on radio button selection
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FeedbackDelegate feedbackDelegate;

            if (radioButtonProgressBar.Checked == true) 
            {
                feedbackDelegate = new FeedbackDelegate(updateProgressBar);
                slowMethod(feedbackDelegate);
            }
            if (radioButtonSpinBox.Checked == true) 
            {
                feedbackDelegate = new FeedbackDelegate(updateSpinBox);
                slowMethod(feedbackDelegate);
            }
            if (radioButtonTrackBar.Checked == true) 
            { 
                feedbackDelegate = new FeedbackDelegate(updateTrackBar);
                slowMethod(feedbackDelegate);
            }    
        }

        //sets displays values to zero
        public void resetDisplays()
        {
            spinBox.Value = 0;
            progressBar.Value = 0;
            trackBar.Value = 0;
            Application.DoEvents();
        }

        //resets values and then calls the delegated update method incrementally
        public void slowMethod(FeedbackDelegate feedbackDelegate)
        {
            resetDisplays();
            int i = 0;
            while (i < 10)
            {
                System.Threading.Thread.Sleep(400);
                feedbackDelegate();
                i++;
            }
            
        }
        //increments spinbox
        public void updateSpinBox()
        {
            spinBox.Value++;
            Application.DoEvents();
        }
        //increments progress bar
        public void updateProgressBar()
        {
            progressBar.PerformStep();
        }
        //increments trackbar
        public void updateTrackBar()
        {
            trackBar.Value++;
        }

    }
}
