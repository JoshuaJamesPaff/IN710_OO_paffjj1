using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Hyena : Animal
    {
        public Hyena()
        {
            name = "Hyena";
            family = "Carnivore";
            food = "almost anything";
            image = new Bitmap(name + ".jpg");
        }
    }
}
