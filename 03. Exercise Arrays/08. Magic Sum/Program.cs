﻿using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

                for (int i = 0; i < numbers.Length; i++)
                {
                   for (int j = i + 1; j < numbers.Length; j++)
                   {
                    int magicSum = numbers[i] + numbers[j];

                    if (magicNum == magicSum)
                    {

                        Console.WriteLine(numbers[i] + " " + numbers[j]);
                    }
                }
            }
        }
    }
}

