using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            Assert.AreEqual(330, calculator.Calculate(33, 10));
            Assert.AreEqual(121, calculator.Calculate(11, 11));
            Assert.AreEqual(-50, calculator.Calculate(25, -2));
        }
    }
}