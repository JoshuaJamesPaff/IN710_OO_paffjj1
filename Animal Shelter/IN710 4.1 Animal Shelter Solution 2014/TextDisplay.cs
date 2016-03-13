using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        private ListBox listBox;

        public TextDisplay(ListBox listBox)
        {
            this.listBox = listBox;
        }
    
        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter crit in critterList)
            {
                listBox.Items.Add(crit.ToString());
            }
        }

        public void clearDisplay()
        {
            listBox.Items.Clear();
        }
    }
}
