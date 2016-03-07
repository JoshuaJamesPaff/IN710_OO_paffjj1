using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joshua_Paff
{
    public class StringList
    {
        //start and end pointers set to null
        public StringNode headPointer = null;
        public StringNode tailPointer = null;

        public StringList()
        {
        }

        // Add node at the start of the list.
        public void AddNode(String newString)
        {
            StringNode newNode = new StringNode(newString);
            if (headPointer != null)
            {
                newNode.Next = headPointer;
                headPointer = newNode;
            }
            else{
                headPointer = newNode;
                tailPointer = newNode;
            }
        }

        // Walk the list, counting the number of StringNodes. Return the count.
        public int Count()
        {
            int nodeCount = 0;
            StringNode nodeWalker = headPointer;
            while (nodeWalker != null)
            {
                nodeCount++;
                nodeWalker = nodeWalker.Next;
            }
            return nodeCount;

        }

        // Delete the StringNode from the list
        public void DeleteNode(StringNode nodeToDelete)
        {
            //if theres only one pellet
            if (headPointer == tailPointer)
            {
                headPointer = null;
                tailPointer = null;
            }

            //if deleting last node
            else if (nodeToDelete == tailPointer)
            {
                StringNode nodeWalker = headPointer;
                while (nodeWalker.Next != nodeToDelete)
                {
                    nodeWalker = nodeWalker.Next;
                }
                tailPointer = nodeWalker;
            }
            // if deleting frist pellet
            else if (headPointer == nodeToDelete)
            {
                headPointer = nodeToDelete.Next;
            }

            //if deleting pellet in linked list longer than 2
            else {
                StringNode nodeWalker = headPointer;
                while (nodeWalker != nodeToDelete)
                {
                    nodeWalker = nodeWalker.Next;
                }
                nodeWalker = nodeToDelete.Next;
            }
        }

        public void AddFirst(String newString)
        {
            AddNode(newString);
        }

        public void RemoveFirst()
        {
            DeleteNode(headPointer);
        }

        public StringNode GetFirst()
        {
            return headPointer;
        }


        
    }
}
