using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class TgCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            TgCalculator calculator = new TgCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
            Assert.AreEqual(1, Math.Round(calculator.Calculate(45)));    
        }
    }
}