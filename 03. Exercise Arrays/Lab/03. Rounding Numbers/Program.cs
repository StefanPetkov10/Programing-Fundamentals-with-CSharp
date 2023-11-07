using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string numbersAsString = "123456";
            //var numbers = new int[numbersAsString.Length];
            //for (int i = 0; i < numbersAsString.Length; i++)
            //{
            //    numbers[i] = numbersAsString[i];
            //}

            //0.4 0.9 1.6 2.35 / if numbers are 0.4, 0.9, 1.6,... Split(',')
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
 