using System;
using System.Linq;

namespace tdd_katas.StringCalculator
{
    public class Calculator
    {
        public static int Add(string input)
        {
            return InputHasNoNumbers(input) ? 0 : InputHasMultipleNumbers(input) ? ParseAndSumMultipleNumbers(input) : ParseSingleNumber(input);
        }

        private static bool InputHasNoNumbers(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        private static bool InputHasMultipleNumbers(string input)
        {
            return input.Contains(",");
        }

        private static int ParseSingleNumber(string input)
        {
            return Convert.ToInt32(input);
        }

        private static int ParseAndSumMultipleNumbers(string input)
        {
            var numbers = input.Split(",".ToCharArray());

            return numbers.Sum(x => Convert.ToInt32(x));
        }
    }
}