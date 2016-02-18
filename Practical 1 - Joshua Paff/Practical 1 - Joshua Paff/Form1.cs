using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1___Joshua_Paff
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("a,b");
            listBox1.Items.Add("c,d");
            listBox1.Items.Add("e,f");
            listBox1.Items.Add("g,h");
        }

        public void TwoToOne()
        {
            const int columnCount = 4;
            const int rowCount = 2;

            Char[] oneDimensional = new Char[columnCount * rowCount];
            Char[,] twoDimensional = new Char[columnCount, rowCount] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };
            
            // convert to one dimension
            for (int c = 0; c < columnCount; c++)
                for (int r = 0; r < rowCount; r++)
                {
                    oneDimensional[(c * 2) + r] = twoDimensional[c,r];
                }

            //printing one dimensional array
            for (int i = 0; i < oneDimensional.Length; i++)
                listBox1.Items.Add(oneDimensional[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TwoToOne();
        }




    }
}
