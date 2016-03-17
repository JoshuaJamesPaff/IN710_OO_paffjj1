using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Hippo : Animal
    {
        public Hippo()
        {
            name = "Hippo";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap(name + ".jpg");
        }

    }
}
