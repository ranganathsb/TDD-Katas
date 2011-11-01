using System;
using System.Linq;

namespace tdd_katas.StringCalculator
{
    public class Calculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            return Convert.ToInt32(input);
        }
    }
}