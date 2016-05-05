using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        //holds picture box list 
        private List<PictureBox> pictureBoxList;

        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }

        //takes a list of critters and sets their ImageFileNames to a picture box
        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                pictureBoxList[i].Image = Image.FromFile(critterList[i].ImageFileName);
            }
        }

        public void clearDisplay()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                //sets picture boxes to null
                pictureBoxList[i].Image = null;
            }
        }
    }
}
