using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.AreEqual(5, calculator.Calculate(100, 20));
            Assert.AreEqual(33, calculator.Calculate(99, 3));
            Assert.AreEqual(12.5, calculator.Calculate(50, 4));
        }
    }
}