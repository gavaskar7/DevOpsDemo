using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int expectedValue = 2;
            int actualValue = calculator.Add(1, 1);
            Assert.AreEqual(expectedValue, actualValue, "Add is not working");
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            int expectedValue = 2;
            int actualValue = calculator.Subtract(3, 1);
            Assert.AreEqual(expectedValue, actualValue, "Subtract is not working");
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            int expectedValue = 20;
            int actualValue = calculator.Multiply(10, 2);
            Assert.AreEqual(expectedValue, actualValue, "Multiply is not working");
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            decimal expectedValue = 5;
            decimal actualValue = calculator.Divide(10, 2);
            Assert.AreEqual(expectedValue, actualValue, "Divide is not working");
        }
    }
}