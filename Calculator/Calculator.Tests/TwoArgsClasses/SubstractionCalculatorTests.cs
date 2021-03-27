using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class SubtractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SubtractionCalculator calculator = new SubtractionCalculator();
            Assert.AreEqual(0, calculator.Calculate(5, 5));
            Assert.AreEqual(10, calculator.Calculate(5, -5));
            Assert.AreEqual(-1.8, calculator.Calculate(1.2, 3));
        }
    }
}