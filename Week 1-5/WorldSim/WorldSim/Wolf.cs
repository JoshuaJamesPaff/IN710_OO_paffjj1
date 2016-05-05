using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap(name + ".jpg");
        }

    }
}
