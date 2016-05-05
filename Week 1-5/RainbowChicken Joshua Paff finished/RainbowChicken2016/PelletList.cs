using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer != null)
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
            else{
                headPointer = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int pelletCount = 0;
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                pelletCount++;
                pelletWalker = pelletWalker.Next;
            }
            return pelletCount;

        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                pelletWalker.Move();
                pelletWalker = pelletWalker.Next;
            }
            
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                if (pelletWalker.TestOutOfBounds(boundsRectangle) == true)
                {
                    pelletWalker.IsAlive = false;
                }
                
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            //if theres only one pellet
            if (headPointer == tailPointer)
            {
                headPointer = null;
                tailPointer = null;
            }

            //if deleting last pellet
            else if (pelletToDelete == tailPointer)
            {
                Pellet pelletWalker = headPointer;
                while (pelletWalker.Next != pelletToDelete)
                {
                    pelletWalker = pelletWalker.Next;
                }
                tailPointer = pelletWalker;
            }
            // if deleting frist pellet
            else if (headPointer == pelletToDelete)
            {
                headPointer = pelletToDelete.Next;
            }

            //if deleting pellet in linked list longer than 2
            else {
                Pellet pelletWalker = headPointer;
                while (pelletWalker != pelletToDelete)
                {
                    pelletWalker = pelletWalker.Next;
                }
                pelletWalker = pelletToDelete.Next;
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {

            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                if (pelletWalker.IsAlive == false)
                {
                    DeleteOne(pelletWalker);
                }
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                pelletWalker.Draw();
                pelletWalker = pelletWalker.Next;
            }
        }
    }
}
