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
  
    
    // uses lamda expressions


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

        //filters all even numbers to listbox using lambda expressions
        private void buttonEven_Click(object sender, EventArgs e)
        {
            FilterNumbers(new Predicate<int>((n)=> n % 2 == 0));
        }

        //filters all numbers under 10 to listbox using lambda expressions
        private void buttonUnder10_Click(object sender, EventArgs e)
        {
            FilterNumbers(new Predicate<int>((n) => n < 10));
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

    }
}
