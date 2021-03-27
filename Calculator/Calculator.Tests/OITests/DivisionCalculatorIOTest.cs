using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class DivisionCalculatorIoTest
    {
        [Test]
        public void CalculateTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.Throws<System.DivideByZeroException>(() => calculator.Calculate(5, 0));
        }
    }
}