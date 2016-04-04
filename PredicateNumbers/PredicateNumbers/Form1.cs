using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //randomly generates 100 numbers and prints them
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBoxAllNums.Items.Clear();
            listBoxSelectedNums.Items.Clear();

            Random rand = new Random();
            int i = 0;
            while (i < 50)
            {
                listBoxAllNums.Items.Add(rand.Next(100));
                i++;
            }
        }

        //filters all even numbers to listbox
        private void buttonEven_Click(object sender, EventArgs e)
        {
            FilterNumbers(new Predicate<int>(isEven));
        }

        //filters all numbers under 10 to listbox
        private void buttonUnder10_Click(object sender, EventArgs e)
        {
            FilterNumbers(new Predicate<int>(isUnderTen));
        }

        //filters and displays numbers depending on predicate input
        private void FilterNumbers(Predicate<int> predicate)
        {

            listBoxSelectedNums.Items.Clear();

            List<int> numbers = new List<int>();

            foreach (int num in listBoxAllNums.Items)
            {
                numbers.Add(num);
            }

            numbers = numbers.FindAll(predicate);

            foreach (int num in numbers)
            {
                listBoxSelectedNums.Items.Add(num);
            } 

        }

        //methods for filtering integers

        public bool isEven(int input)
        {
            bool isEven = ((input % 2) == 0);
            return isEven;
        }

        private bool isUnderTen(int input)
        {
            bool isUnderTen = (input < 10);
            return isUnderTen;
        }
    }
}
