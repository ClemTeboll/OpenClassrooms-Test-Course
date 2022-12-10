using System;
using System.Linq;

namespace CalculatorProgram
{
    public class Calculator
    {
        public decimal Current { get; private set; }

        static void Main()
        {
            Console.WriteLine("App is lauched!");
        }

        public decimal Sum(params decimal[] numbers)
        {
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

        public decimal Reset()
        {
            return Current = 0;
        }
    }
}