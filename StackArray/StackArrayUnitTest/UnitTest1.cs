using System;
using StackArray_Prob;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackArrayUnitTest
{
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPush()
        {
            int[] val = new int[10] {1,0,0,0,0,0,0,0,0,0};
            var testInstance = new StackArray();
            var testResult = testInstance.Push(1);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }

        [TestMethod]
        public void TestMethodPop()
        {
            int[] val = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Pop(1);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }

        [TestMethod]
        public void TestMethodPeek()
        {
            int[] val = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Peek(1);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }

        [TestMethod]
        public void TestMethodResizeBigger()
        {
            int[] val = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Resize(15);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }
        [TestMethod]
        public void TestMethodResizeSmaller()
        {
            int[] val = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var testInstance = new StackArray();
            var testResult = testInstance.Resize(5);
            Assert.AreEqual(val, testResult, "The result should be an Array of size 10 with one entry");
        }

    }
}
