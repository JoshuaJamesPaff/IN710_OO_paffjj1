using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public partial class Form1 : Form
    {
        //creates subject and observers
        private SubjectWithEvent subjectWithEvent;
        private Observer observer1;
        private Observer observer2;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            random = new Random();

            subjectWithEvent = new SubjectWithEvent();

            //creates observers (already bound to button.Click)
            observer1 = new Observer(subjectWithEvent, "One", buttonTestHandlers, random);
            observer2 = new Observer(subjectWithEvent, "Two", buttonTestHandlers, random);
        }

        private void buttonTestHandlers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the forms handler");
        }
    }
}
