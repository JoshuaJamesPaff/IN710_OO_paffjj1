using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class Animal
    {

        protected string name;
        protected string family;
        protected string food;
        protected Bitmap image;
        public Bitmap Image
        {
            get { return image; }
        }

        public override string ToString()
        {
            string displayString = "I am " + name + ". I am a " + family + ". I eat " + food + ".";
            return displayString;
        }

    }
}
