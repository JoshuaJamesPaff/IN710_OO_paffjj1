using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public class MultiPCBuilder : IPCBuilder
    {
        public List<Component> setComponents()
        {
            //sets multimedia components for this build
            List<Component> multiSpecs = new List<Component>();
            multiSpecs.Add(new GFX("AMD Radeon 2GB 800MHZ", 300));
            multiSpecs.Add(new CPU("Intel i5 quad-core 3.2GHZ", 200));
            multiSpecs.Add(new RAM("Corsair DDR3 1800MHZ 4GB", 350));
            multiSpecs.Add(new Monitor("LG 24' 1080p", 350));

            return multiSpecs;
        }
    }
}
