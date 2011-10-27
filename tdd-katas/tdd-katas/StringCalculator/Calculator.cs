using System;
using System.Linq;

namespace tdd_katas.StringCalculator
{
    public class Calculator
    {
        public static int Add(string input)
        {
            return string.IsNullOrEmpty(input) ? 0 : input.Contains(",") ? input.Split(",".ToCharArray()).Sum(number => ParseSingleNumber(number)) : ParseSingleNumber(input);
        }

        private static int ParseSingleNumber(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}