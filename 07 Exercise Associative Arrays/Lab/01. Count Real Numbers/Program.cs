using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcc    //var numberOcc
                = new SortedDictionary<double, int>();

            double[] inputNumber = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

            foreach (var currNum in inputNumber)
            {
                if (!numberOcc.ContainsKey(currNum))
                {
                    numberOcc.Add(currNum, 0);
                }

                numberOcc[currNum] += 1;
            }

            foreach (var (key, value) in numberOcc)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
