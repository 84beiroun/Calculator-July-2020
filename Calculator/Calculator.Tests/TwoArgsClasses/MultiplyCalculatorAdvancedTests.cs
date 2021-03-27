using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class MultiplyCalculatorAdvancedTests
    {
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(5, 2, 10)]
        [TestCase(99, 99, 9801)]
        [TestCase(5.23, 5.22, 27.3006)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}