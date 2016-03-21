using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Character
    {
        private string name;       
        private string head;
        private string body;
        private string legs;

        public Character(string name, string head, string body, string legs)
        {
            this.name = name;
            this.head = head;
            this.body = body;
            this.legs = legs;
        }

        override public string ToString(){
            return name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Head
        {
            get { return head; }
            set { head = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public string Legs
        {
            get { return legs; }
            set { legs = value; }
        } 


    }
}
