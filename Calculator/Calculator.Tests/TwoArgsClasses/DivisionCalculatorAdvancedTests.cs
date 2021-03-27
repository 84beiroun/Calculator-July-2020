using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class DivisionCalculatorAdvancedTests
    {
        [Test]
        [TestCase(0, 5, 0)]
        [TestCase(5, 2, 2.5)]
        [TestCase(99, 99, 1)]
        [TestCase(66, 33, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            DivisionCalculator calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
            
        }
    }
}