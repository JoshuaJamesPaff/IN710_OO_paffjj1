using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public class LaptopPCBuilder : IPCBuilder
    {
        public List<Component> setComponents()
        {
            //sets multimedia components
            List<Component> multiSpecs = new List<Component>();
            multiSpecs.Add(new GFX("Intel Iris 1.5GB 800MHZ", 320));
            multiSpecs.Add(new CPU("Intel i5 mobile dual-core 3.0GHZ", 300));
            multiSpecs.Add(new RAM("Generic DDR3 1800MHZ 4GB", 380));

            return multiSpecs;
        }
    }
}
