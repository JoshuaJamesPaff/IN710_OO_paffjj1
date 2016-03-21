using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        private CharacterManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new CharacterManager();

            //adds values to combo boxes
            foreach(Character c in manager.getCharacterList()){
                comboBoxHead.Items.Add(c.Name);
                comboBoxBody.Items.Add(c.Name);
                comboBoxLegs.Items.Add(c.Name);
            }
            //sets default selection for each combo box
            comboBoxHead.SelectedIndex = 0;
            comboBoxBody.SelectedIndex = 0;
            comboBoxLegs.SelectedIndex = 0;

            //prints default monster
            printMonster();

        }

        private void printMonster()
        {
            //creates new character based on selections from 3 combo boxes
            Character newChar = manager.createCharacter(
            manager.getCharacterList()[comboBoxHead.SelectedIndex].Head,
            manager.getCharacterList()[comboBoxBody.SelectedIndex].Body,
            manager.getCharacterList()[comboBoxLegs.SelectedIndex].Legs);

            //ptints images of that character
            pictureBoxTop.Image = manager.printBitmaps(newChar)[0];
            pictureBoxMiddle.Image = manager.printBitmaps(newChar)[1];
            pictureBoxBottom.Image = manager.printBitmaps(newChar)[2];
        }

        //creates and prints out new monster when button clicked
        private void buttonMakeMonster_Click(object sender, EventArgs e)
        {
            printMonster();
        }
    }
}
