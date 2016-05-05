using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        List<Character> characterList = new List<Character>();
        
        public Form1()
        {
            InitializeComponent();
        }

        //updates checked list boxes
        public void UpdateLists()
        {
            //clears lists
            checkedListBoxCharacters.Items.Clear();
            checkedListBoxWeapon.Items.Clear();
            //adds names
            foreach(Character character in characterList){
                //character.setNameToDisplay();
                checkedListBoxCharacters.Items.Add(character);
            }
            // sets the weapon listbox to the same as the characters
            int i = 0;
            int k = 0;
            i = checkedListBoxCharacters.Items.Count;
            for (k = 0; k != i; k++)
            {
                checkedListBoxWeapon.Items.Add(checkedListBoxCharacters.Items[k]);
            } 
        }

        //adds character 
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Default Name";
            }
            if (rdKing.Checked == true) characterList.Add(new King(txtName.Text, listBoxBattle));
            if (rdQueen.Checked == true) characterList.Add(new Queen(txtName.Text, listBoxBattle));
            if (rdTroll.Checked == true) characterList.Add(new Troll(txtName.Text, listBoxBattle));
            if (rdKnight.Checked == true) characterList.Add(new Knight(txtName.Text, listBoxBattle));
            UpdateLists();
            
        }

        //changes weapons of all the selected characters to the weapon selected in the radio group
        private void buttonChangeWeapon_Click(object sender, EventArgs e)
        {
            IWeapon changedWeapon = new SwordWeapon();
            if (rdKnife.Checked == true) changedWeapon = new KnifeWeapon();
            if (rdBow.Checked == true) changedWeapon = new BowWeapon();
            if (rdSword.Checked == true) changedWeapon = new SwordWeapon();
            foreach (Character checkedCharacter in checkedListBoxWeapon.CheckedItems)
            {
                checkedCharacter.ChangeWeapon(changedWeapon);
            }
        }

        //calls the declare method on the two selected characters or shows a message box 
        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCharacters.CheckedItems.Count != 2)
            {
                MessageBox.Show("Please select ONLY two characters for battle"); 
            }
            else
            {
                foreach (Character checkedCharacter in checkedListBoxCharacters.CheckedItems)
                {
                    checkedCharacter.Declare();
                    listBoxBattle.Items.Add("");
                }
            }
            
        }
    }
}
