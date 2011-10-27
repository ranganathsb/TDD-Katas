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
            var delimiter = GetPossibleDelimiters();
            var numbers = input;

            if (input.StartsWith("//"))
            {
                delimiter = input.Substring(2, input.IndexOf("\n") - 2);
                numbers = input.Substring(input.IndexOf("\n") + 1, input.Length - input.IndexOf("\n") - 1);
            }
            return ContainsAny(input, delimiter) ? ParseMultipleNumbers(numbers, delimiter) : ParseSingleNumber(numbers);
        }

        private static string GetPossibleDelimiters()
        {
            return ",\n";
        }

        private static bool ContainsAny(string input, string getPossibleDelimiters)
        {
            return getPossibleDelimiters.ToCharArray().Any(input.Contains);
        }

        private static int ParseMultipleNumbers(string input, string delimiter)
        {
            var numbers = input.Split(delimiter.ToCharArray());

            var result = numbers.Sum(number => ParseSingleNumber(number));
            return result;
        }

        private static int ParseSingleNumber(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}