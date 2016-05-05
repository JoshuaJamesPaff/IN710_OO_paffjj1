using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizScorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creates delegate 
        public delegate int ScoreDelegate(int correct, int incorrect);

        ScoreDelegate scoreComputer;

        private void buttonComputeScore_Click(object sender, EventArgs e)
        {
            //sets the delegate based on radio button selection
            if (radioButtonAdult.Checked == true)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            if (radioButtonChild.Checked == true)
            {
                scoreComputer = new ScoreDelegate(Scorer.ChildScore);
            }

            //creates variables for inputs and checks if they are numeric
            int correct;
            int incorrect;
            bool isCorrectNumeric = int.TryParse(textBoxCorrect.Text, out correct);
            bool isIncorrectNumeric = int.TryParse(textBoxIncorrect.Text, out incorrect);

            //if inputs are valid set the score label else display error msg
            if (isCorrectNumeric == true && isIncorrectNumeric == true)
            {
                labelScore.Text = scoreComputer(correct, incorrect).ToString();
            }
            else
            {
                MessageBox.Show("Please make sure only numeric values are entered into the fields.");
            }
            
            
        }


    }
}
