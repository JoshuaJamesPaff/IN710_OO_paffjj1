using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joshua_Paff
{
    public class StringNode
    {
        public String stringValue;
        public StringNode Next { get; set; }
        public String Previous { get; set; }

        public StringNode(String newString){
            stringValue = newString;
        }

        public String toString()
        {
            return stringValue;
        }
    }
}
