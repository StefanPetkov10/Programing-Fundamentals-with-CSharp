using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < array.Count / 2; i++)
            {
                int currSum = array[i] + array[array.Count - 1 - i];

                result.Add(currSum);
            }
            if (array.Count % 2 != 0)
            {
                result.Add(array[array.Count / 2]);
            }

            Console.WriteLine(string.Join(" ",result));     
        }
    }
}
