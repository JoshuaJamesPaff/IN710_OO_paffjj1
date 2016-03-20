using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public abstract class Component
    {
        protected string name;
        protected int price;

        public Component(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        override public string ToString()
        {
            return price + "\t" + name;
        }

        public int getPrice(){
            return price;
        }
    }
}
