using System;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            double average = 0;

            if (arr.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            average = arr.Sum() / (double)arr.Count();
            var matchingNumbersCount = arr.Where(x => x > average)
                .ToArray()
                .Count();

            if (matchingNumbersCount == 0)
            {
                Console.WriteLine("No");
            }
            else if (arr.Count < 5)
            {
                Console.WriteLine("Less than 5 numbers");
            }
            else
            {
                var result = arr.OrderByDescending(x => x)
                    .Where(x => x > average).Take(5).ToArray();

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
