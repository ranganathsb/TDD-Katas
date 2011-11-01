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
            
            if (input.Contains(","))
            {
                var numbers = input.Split(",".ToCharArray());

                return numbers.Sum(x => Convert.ToInt32(x));
            }
            
            return Convert.ToInt32(input);
        }
    }
}