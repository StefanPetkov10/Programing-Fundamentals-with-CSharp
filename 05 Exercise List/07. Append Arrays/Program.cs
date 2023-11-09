using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numberGroups = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            for (int i = 0; i < numberGroups.Count; i++)
            {
                List<string> numbers = numberGroups[i]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.Write($"{numbers[j]} ");
                }
            }
        }
    }
}
