using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public class GamingPCBuilder : IPCBuilder
    {
        public List<Component> setComponents()
        {
            //sets gaming components
            List<Component> gamingSpecs = new List<Component>();
            gamingSpecs.Add(new GFX("AMD Radeon 4GB 1GHZ", 500));
            gamingSpecs.Add(new CPU("Intel i7 quad-core 4GHZ", 400));
            gamingSpecs.Add(new RAM("Corsair DDR4 2100MHZ 12GB", 750));
            gamingSpecs.Add(new Monitor("LG 24' 1080p", 350));

            return gamingSpecs;
        }
    }
}
