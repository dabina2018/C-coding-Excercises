using System;
using StackArray_Prob;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackArrayUnitTest
{
    public class UnitTest1
    {
        //0 will represent null or empty index value

        [TestMethod]
        public void TestMethodPush()
        {
            int[] val = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Push(1);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }
        [TestMethod]
        public void TestMethodPush2()
        {
            int[] val = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            for (int i = 1; i < 6; i++)
            {
                testInstance.Push(i);
            }
            var testResult = testInstance.Push(6);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with six entries");
        }

        [TestMethod]
        public void TestMethodPush3()
        {
            int[] val = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testInstance = new StackArray();
            for (int i = 1; i < 11; i++)
            {
                testInstance.Push(i);
            }           
            var testResult = testInstance.Push(11);
            Assert.AreEqual(val, testResult, "The method should return a message if the Array is full");
        }

        [TestMethod]
        public void TestMethodPop()
        {
            int[] val = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testInstance = new StackArray();
            for (int i = 1; i < 11; i++)
            {
                testInstance.Push(i);
            }
            var testResult = testInstance.Pop();
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with 9 entries");
        }

        [TestMethod]
        public void TestMethodPop2()
        {
            int[] val = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Pop();
            Assert.AreEqual(val, testResult, "The method should return an error if the array is empty");
        }

        [TestMethod]
        public void TestMethodPeek()
        {
            int[] val = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testInstance = new StackArray();
            for (int i = 1; i < 11; i++)
            {
                testInstance.Push(i);
            }
            var testResult = testInstance.Peek();
            Assert.AreEqual(val, testResult, "The method should return the last value added to the stack");
        }

        [TestMethod]
        public void TestMethodPeek2()
        {
            int[] val = new int[10] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testInstance = new StackArray();
            var testResult = testInstance.Peek();
            Assert.AreEqual(val, testResult, "The method should display a message if the Array is empty");
        }

        [TestMethod]
        public void TestMethodResizeBigger()
        {
            int[] val = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Resize(15);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 15");
        }
        [TestMethod]
        public void TestMethodResizeSmaller()
        {
            int[] val = new int[5] { 0, 0, 0, 0, 0};
            var testInstance = new StackArray();
            var testResult = testInstance.Resize(5);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 5");
        }

    }
}