using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class SqrtCalculatorIOTest
    {
        [Test]
        public void CalculateTest()
        {
            SqrtCalculator calculator = new SqrtCalculator();
            Assert.Throws<System.DivideByZeroException>(() => calculator.Calculate(-5));
        }
    }
}