using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {

        //has subject object
        private FireAlarmSubject subject;

        public Form1()
        {
            InitializeComponent();

            subject = new FireAlarmSubject();

            //sets observers to subject (beep first then message)
            FireAlarmBeep beepEvent = new FireAlarmBeep(subject);
            FireAlarmMessage messageEvent = new FireAlarmMessage(subject);
            
        }

        //when clicked gets the selected level and passes it to subject
        private void buttonActivateAlarm_Click(object sender, EventArgs e)
        {
            //
             EFireLevel level;

            if (radioButtonMinor.Checked)
                level = EFireLevel.MINOR;
            else if (radioButtonSerious.Checked)
                level = EFireLevel.SERIOUS;
            else
                level = EFireLevel.INFERNO;

            subject.OnFire(level);

        }
    }
}
