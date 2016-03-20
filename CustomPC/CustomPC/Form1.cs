using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public partial class Form1 : Form
    {
        //holds data for selected pc
        private PC currentPC;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrintPC_Click(object sender, EventArgs e)
        {
            if (rbBusinessPC.Checked) 
            {
                currentPC = new BusinessPC(listBoxDisplaySpecs);
                currentPC.BuildPC();
                currentPC.ShowSpecs();
            }
            else if (rbGamingPC.Checked)
            {
                currentPC = new GamingPC(listBoxDisplaySpecs);
                currentPC.BuildPC();
                currentPC.ShowSpecs();
            }
            else if (rbLaptop.Checked)
            {
                currentPC = new LaptopPC(listBoxDisplaySpecs);
                currentPC.BuildPC();
                currentPC.ShowSpecs();
            }
            else
            {
                currentPC = new MultiPC(listBoxDisplaySpecs);
                currentPC.BuildPC();
                currentPC.ShowSpecs();
            }
        }
    }
}
