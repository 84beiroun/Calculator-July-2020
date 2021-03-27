using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            Assert.AreEqual(10, calculator.Calculate(5, 5));
            Assert.AreEqual(26, calculator.Calculate(12, 14));
            Assert.AreEqual(5.3, calculator.Calculate(5.2, 0.1));
        }
    }
}
