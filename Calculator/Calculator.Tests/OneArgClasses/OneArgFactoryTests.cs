using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgsClasses
{
    [TestFixture]
    public class OneArgFactoryTests
    {
        [Test]
        [TestCase("sqrt", typeof(SqrtCalculator))]
        [TestCase("sin", typeof(SinCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        [TestCase("tg", typeof(TgCalculator))]
        [TestCase("ctg", typeof(CtgCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}