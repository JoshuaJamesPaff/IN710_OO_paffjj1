using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSim
{
    public class Africa : Continent
    {
        public Africa(ListBox displayBox, Random randGen, int numAnimals, Graphics canvas)
            :base(displayBox, randGen, numAnimals, canvas)
        {
            animalFactory = new AfricanAnimalFactory();
        }
        
    }
}
