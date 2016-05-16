using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //animal + thread object
        private Animal mainAnimal;
        private Thread speakThread;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
        }

        //calls animal.speak in new thread
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            speakThread = new Thread(mainAnimal.speak);
            speakThread.Start();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        //aborts animal.speak when stop clicked
        private void buttonStop_Click(object sender, EventArgs e)
        {   
            speakThread.Abort();
        }

        //aborts animal.speak when form close clicked
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            speakThread.Abort();
        }
    }
}
