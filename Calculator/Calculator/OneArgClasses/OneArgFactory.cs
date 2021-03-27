namespace Calculator.OneArgClasses
{
  public static class OneArgFactory
    {
        public static IOneArgCalculator CreateCalculator(string oper)
        {
            switch (oper)
            {
                case ("sin"): return new SinCalculator();
                case ("cos"): return new CosCalculator();
                case ("tg"): return new TgCalculator();
                case ("ctg"): return new CtgCalculator();
                case ("sqrt"): return new SqrtCalculator();
    }
            return null;
        }
    }
}
