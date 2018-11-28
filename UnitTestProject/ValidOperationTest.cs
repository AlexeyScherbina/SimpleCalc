using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalc;

namespace UnitTestProject
{
    [TestClass]
    public class ValidOperationTest
    {
        [TestMethod]
        public void TestSumm()
        {
            double a = 5, b = 10;
            double expected = 15;
            double actual = Operations.Summ(a, b);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestSubtraction()
        {
            double a = 37, b = 19;
            double expected = 18;
            double actual = Operations.Subtraction(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            double a = 4.4, b = 5;
            double expected = 22;
            double actual = Operations.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivision()
        {
            double a = 121, b = 11;
            double expected = 11;
            double actual = Operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
