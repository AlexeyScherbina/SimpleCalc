﻿using System;
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

        [TestMethod]
        public void TestNotEqualSumm()
        {
            double a = 15, b = 9;
            double expected = 21;
            double actual = Operations.Summ(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestNotEqualSubtraction()
        {
            double a = 29, b = 68;
            double expected = -40;
            double actual = Operations.Subtraction(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestNotEqualMultiplication()
        {
            double a = 14, b = 5;
            double expected = 22;
            double actual = Operations.Multiplication(a, b);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestNotEqualDivision()
        {
            double a = 1, b = 11;
            double expected = 121;
            double actual = Operations.Division(a, b);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
