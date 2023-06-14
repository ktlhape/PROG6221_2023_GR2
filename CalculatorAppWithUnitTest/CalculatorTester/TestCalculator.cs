using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorApp;
using System.Globalization;

namespace CalculatorTester
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num1 = 5;
            int num2 = 2;
            int expected = 7;
            //Act
            int actual = num1 + num2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum()
        {
            //Arrange
            double x = 1;
            double y = 1;
            double expected = 2;
            //Act
            Calculator calc = new Calculator();
            double actual = calc.Sum(x, y);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
