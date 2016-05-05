using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Buffalo : Animal
    {
        public Buffalo()
        {
            name = "Buffalo";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap(name + ".jpg");
        }

    }
}
