using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks_Joshua_Paff;


namespace UnitTestProjectStacks
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void IsEmptyNewStack_ReturnsTrue()
        {
            Stack stack = new Stack();
            bool expected = true;

            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual, "New Stack is not empty");
        }

        [TestMethod]
        public void PushedStackIsEmpty_ReturnsFalse()
        {
            Stack stack = new Stack();
            stack.Push("one");

            bool expected = false;

            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual, "The pushed stack is empty");
        }

        [TestMethod]
        public void IsEmptyPoppedStack_ReturnsTrue()
        {
            Stack stack = new Stack();
            stack.Push("one");
            stack.Pop();

            bool expected = true;

            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual, "The popped stack is not empty");
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PeekEmptyStack_ReturnsException()
        {
            Stack stack = new Stack();
            stack.Peek();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PopEmptyStack_ReturnsException()
        {
            Stack stack = new Stack();
            stack.Pop();
        }

        [TestMethod]
        public void PushPop_ReturnsPushValue()
        {
            Stack stack = new Stack();

            String pushed = "one";
            stack.Push(pushed);
            String popped = stack.Pop();

            Assert.AreEqual(pushed, popped, "Popped value does not equal pushed value");
           
        }

        [TestMethod]
        public void PushPop_DeletesPopValue()
        {
            Stack stack = new Stack();

            String pushed = "one";
            stack.Push(pushed);
            stack.Pop();
            bool expectedBool = true;
            bool actualBool = stack.IsEmpty();

            Assert.AreEqual(expectedBool, actualBool, "Popped value not deleted");
        }

        [TestMethod]
        public void PushPeek_ReturnsPushValue()
        {
            Stack stack = new Stack();

            String pushed = "one";
            stack.Push(pushed);
            String peeked = stack.Peek();

            Assert.AreEqual(pushed, peeked, "Pushed value does not equal peeked value");

        }

        [TestMethod]
        public void PushPeek_RetainsPeekValue()
        {
            Stack stack = new Stack();

            String pushed = "one";
            stack.Push(pushed);
            stack.Peek();
            bool expectedBool = false;

            bool actualBool = stack.IsEmpty();

            Assert.AreEqual(expectedBool, actualBool, "Peeked value not on top of stack");
        }

        [TestMethod]
        public void CountNewStack_ReturnsZero()
        {
            Stack stack = new Stack();

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count of new stack does not equal 0");
        }

        [TestMethod]
        public void PushCount_ReturnsCountOfPushed()
        {
            Stack stack = new Stack();

            String pushed1 = null;
            String pushed2 = "";
            String pushed3 = "three"; 
            stack.Push(pushed1);
            stack.Push(pushed2);
            stack.Push(pushed3);

            int expected = 3;
            int actual = stack.Count();
            
            Assert.AreEqual(expected, actual, "Number of items pushed does not equal number of items counted");
        }

        [TestMethod]
        public void PushPopCount_ReturnsZero()
        {
            Stack stack = new Stack();

            String pushed1 = "one";
           
            stack.Push(pushed1);
            stack.Pop();

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Popped stack not empty");
        }

    }
}
