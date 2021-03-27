using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class SqrtCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SqrtCalculator calculator = new SqrtCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
            Assert.AreEqual(1, calculator.Calculate(1));
            Assert.AreEqual(4, calculator.Calculate(16));
        }
    }
}