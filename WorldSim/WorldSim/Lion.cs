using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Lion : Animal
    {
        public Lion()
        {
            name = "Lion";
            family = "Carnivore";
            food = "Bugs";
            image = new Bitmap(name + ".jpg");
        }

    }
}
