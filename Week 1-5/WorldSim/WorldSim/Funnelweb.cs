using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Funnelweb : Animal
    {
        public Funnelweb()
        {
            name = "Funnel-web Spider";
            family = "Carnivore";
            food = "Bugs";
            image = new Bitmap(name + ".jpg");
        }

    }
}
