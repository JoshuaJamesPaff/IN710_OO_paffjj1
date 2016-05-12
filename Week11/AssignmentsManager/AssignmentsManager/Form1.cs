using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentsManager
{
    public partial class Form1 : Form
    {
        DBManager dbm;

        public Form1()
        {
            InitializeComponent();
            dbm = new DBManager(listBoxOutput);
        }

        private void buttonAllPapers_Click(object sender, EventArgs e)
        {
            dbm.ShowPapers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbm.ShowAssignments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbm.ShowAverageMark();
        }
    }
}
