using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public abstract class Component
    {
        //has a name and a price
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

        //returns the price property
        public int getPrice(){
            return price;
        }
    }
}
