using System;

namespace Calculator.OneArgClasses
{
    public class SqrtCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            try
            {
                if (FirstNumber < 0)
                    throw new Exception("BelowZeroException");
                return (Math.Sqrt(FirstNumber));
            }
            catch (Exception)
            {
                return (Double.NaN);

            }
        }
    }
}
