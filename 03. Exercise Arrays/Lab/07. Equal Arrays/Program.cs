using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] number2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool isdentikal = false; 

            for (int i = 0; i < number1.Length; i++)
            {
                if (number1[i] != number2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isdentikal = false;
                    break;
                }
               else
                {
                    sum += number1[i];
                    isdentikal = true;
                }               
            }
            if (isdentikal)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
