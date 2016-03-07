using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joshua_Paff
{
    public class StringNode
    {
        //holds a string and a next value
        public String stringValue;
        public StringNode Next { get; set; }

        //constructor sets string and next values
        public StringNode(String newString){
            stringValue = newString;
            Next = null;
        }

        //gets the string value
        public String toString()
        {
            return stringValue;
        }
    }
}
