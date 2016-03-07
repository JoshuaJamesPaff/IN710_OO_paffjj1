using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joshua_Paff
{
    public class Stack
    {
        //linked list of strings to hold stack values
        private LinkedList<String> stack;

        // constructor initialises linked list
        public Stack()
        {
            stack = new LinkedList<String>();
        }

        //adds newString to the top of the stack
        public void Push(String newString)
        {
            stack.AddFirst(newString);
        }

        // removes and returns first string from stack
        public String Pop()
        {
            if (stack.Count() > 0 )
            {
                String firstString = stack.First();
                stack.RemoveFirst();
                return firstString;
            }
            else
            {
                throw new System.ArgumentNullException("There are no Strings in the Stack pop.");
            }
        }

        // returns first string on stack, returns exception if empty
        public String Peek()
        {
            if (stack.Count() > 0)
            {
                return stack.First();
            }
            else
            {
                throw new System.InvalidOperationException("There are no Strings in the Stack to peek at.");
            }

        }

        //returns number of items in stack
        public int Count()
        {
            return stack.Count();
          
        }

        //if stack has 0 elements returns true, else false
        public bool IsEmpty()
        {
            if (stack.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
