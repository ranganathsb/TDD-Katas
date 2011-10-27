using System;
using System.Linq;

namespace tdd_katas.StringCalculator
{
    public class Calculator
    {
        public static int Add(string input)
        {
            return string.IsNullOrEmpty(input) ? 0 : ParseInput(input);
        }

        private static int ParseInput(string input)
        {
            return ContainsAny(input, GetPossibleDelimiters()) ? ParseMultipleNumbers(input) : ParseSingleNumber(input);
        }

        private static string GetPossibleDelimiters()
        {
            return ",\n";
        }

        private static bool ContainsAny(string input, string getPossibleDelimiters)
        {
            return getPossibleDelimiters.ToCharArray().Any(input.Contains);
        }

        private static int ParseMultipleNumbers(string input)
        {
            var numbers = input.Split(GetPossibleDelimiters().ToCharArray());

            var result = numbers.Sum(number => ParseSingleNumber(number));
            return result;
        }

        private static int ParseSingleNumber(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}