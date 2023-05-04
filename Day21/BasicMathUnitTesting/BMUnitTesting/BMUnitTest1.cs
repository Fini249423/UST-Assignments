using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMathUnitTesting;

namespace BMUnitTesting
{
    [TestClass]
    public class BMUnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
