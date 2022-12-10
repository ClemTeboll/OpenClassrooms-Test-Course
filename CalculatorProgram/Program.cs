using System;
using System.Linq;

namespace CalculatorProgram
{
    public class Calculator
    {
        static void Main()
        {
            Console.WriteLine("App is lauched!");
        }

        public decimal Sum(params decimal[] numbers)
        {
            decimal Current = 0;

            if (numbers.Length == 1)
            {
                Current += numbers[0];
                return Current;
            }

            var result = 0.0M;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}