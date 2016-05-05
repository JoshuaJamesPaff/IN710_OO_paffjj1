using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Gorilla : Animal
    {
        public Gorilla()
        {
            name = "Gorilla";
            family = "Herbivore";
            food = "Bananas";
            image = new Bitmap(name + ".jpg");
        }

    }
}
