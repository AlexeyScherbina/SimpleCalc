using System;
using NUnit.Framework;
using SimpleCalc;

namespace Tests
{
    public class OperationTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Summ_Numbers_Equal()
        {
            double a = 5, b = 10;
            double expected = 15;
            double actual = Operations.Summ(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Subtraction_Numbers_Equal()
        {
            double a = 37, b = 19;
            double expected = 18;
            double actual = Operations.Subtraction(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Multiplication_Numbers_Equal()
        {
            double a = 4.4, b = 5;
            double expected = 22;
            double actual = Operations.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_Numbers_Equal()
        {
            double a = 121, b = 11;
            double expected = 11;
            double actual = Operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Summ_Numbers_NotEqual()
        {
            double a = 15, b = 9;
            double expected = 21;
            double actual = Operations.Summ(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Subtraction_Numbers_NotEqual()
        {
            double a = 29, b = 68;
            double expected = -40;
            double actual = Operations.Subtraction(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Multiplication_Numbers_NotEqual()
        {
            double a = 14, b = 5;
            double expected = 22;
            double actual = Operations.Multiplication(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Division_Numbers_NotEqual()
        {
            double a = 1, b = 11;
            double expected = 121;
            double actual = Operations.Division(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Division_DivisionByZero_Infinity()
        {
            double a = 1, b = 0;
            double expected = Double.PositiveInfinity;
            double actual = Operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_Zeros_Nan()
        {
            double a = 0, b = 0;
            double expected = Double.NaN;
            double actual = Operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_Null_Exception()
        {
            double? a = null, b = null;
            try
            {
                Operations.Division((double)a, (double)b);
                Assert.Fail("No exception thrown");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is InvalidOperationException);
            }
        }
    }
}