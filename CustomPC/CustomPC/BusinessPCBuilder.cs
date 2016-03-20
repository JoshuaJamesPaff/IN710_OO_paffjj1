using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public class BusinessPCBuilder : IPCBuilder
    {
        public List<Component> setComponents()
        {
            //sets multimedia components
            List<Component> businessSpecs = new List<Component>();
            businessSpecs.Add(new GFX("AMD Radeon 1GB 750MHZ", 290));
            businessSpecs.Add(new CPU("Intel i5 quad-core 3.2GHZ", 200));
            businessSpecs.Add(new RAM("Corsair DDR3 1800MHZ 2GB", 320));

            return businessSpecs;
        }
    }
}
