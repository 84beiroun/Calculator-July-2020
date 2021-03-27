using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SinCalculator calculator = new SinCalculator();
            Assert.AreEqual(1, calculator.Calculate(90));
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}