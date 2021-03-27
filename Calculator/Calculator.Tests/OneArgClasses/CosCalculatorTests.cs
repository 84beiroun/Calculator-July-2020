using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            CosCalculator calculator = new CosCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }
    }
}