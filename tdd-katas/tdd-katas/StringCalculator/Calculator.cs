using System;
using System.Linq;

namespace tdd_katas.StringCalculator
{
    public class Calculator
    {
        public static int Add(string input)
        {
            return string.IsNullOrEmpty(input) ? 0 : ParseSingleNumber(input);
        }

        private static int ParseSingleNumber(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}