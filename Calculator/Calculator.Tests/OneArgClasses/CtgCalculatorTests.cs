using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class CtgCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            CtgCalculator calculator = new CtgCalculator();
            Assert.AreEqual(0, Math.Round(calculator.Calculate(90)));
            Assert.AreEqual(1, Math.Round(calculator.Calculate(45)));
        }
    }
}