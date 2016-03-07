using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joshua_Paff
{
    public class Stack
    {
        //linked list of stringnodes
        private StringList stack;

        // constructor initialises linked list
        public Stack()
        {
            stack = new StringList();
        }

        //adds newString to the top of the stack
        public void Push(String newString)
        {
            stack.AddFirst(newString);
        }

        // removes first string node from stack and returns its string value
        public String Pop()
        {
            if (stack.Count() > 0 )
            {
                StringNode firstString = stack.GetFirst();
                stack.RemoveFirst();
                return firstString.toString();
            }
            else
            {
                throw new System.ArgumentNullException("There are no Strings in the Stack pop.");
            }
        }

        // returns first stringnode on stack, returns exception if empty
        public String Peek()
        {
            if (stack.Count() > 0)
            {
                return stack.GetFirst().toString();
            }
            else
            {
                throw new System.InvalidOperationException("There are no StringNodes in the Stack to peek at.");
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
