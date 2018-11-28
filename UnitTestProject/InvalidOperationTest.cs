using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalc;

namespace UnitTestProject
{
    [TestClass]
    public class InvalidOperationTest
    {
        [TestMethod]
        public void TestSumm()
        {
            double a = 12, b = 9;
            double expected = 21;
            double actual = Operations.Summ(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubtraction()
        {
            double a = 28, b = 68;
            double expected = -40;
            double actual = Operations.Subtraction(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            double a = 14, b = 5;
            double expected = 22;
            double actual = Operations.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivision()
        {
            double a = 1, b = 11;
            double expected = 121;
            double actual = Operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
