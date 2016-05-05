using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSim
{
    public class NorthAmerica : Continent
    {
        public NorthAmerica(ListBox displayBox, Random randGen, int numAnimals, Graphics canvas)
            :base(displayBox, randGen, numAnimals, canvas)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
       
    }
}
