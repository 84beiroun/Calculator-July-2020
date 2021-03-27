using System;
using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            PowCalculator calculator = new PowCalculator();
            Assert.AreEqual(0, calculator.Calculate(0, 2));
            Assert.AreEqual(4, calculator.Calculate(2, 2));
            Assert.AreEqual(10000, calculator.Calculate(100, 2));
        }
    }
}