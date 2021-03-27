using System;

namespace Calculator.OneArgClasses
{
    public class CtgCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (1.0/Math.Tan(FirstNumber * Math.PI / 180));
        }
    }
}
