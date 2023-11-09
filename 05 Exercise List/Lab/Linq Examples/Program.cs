using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
                { 1,2,3,4,5,6,7,8,9, 10 };


            //numbers.Sum()
            Console.WriteLine(numbers.Sum());

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);


            //Min
            Console.WriteLine(numbers.Min());

            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine(minNumber);


            //Max
            Console.WriteLine(numbers.Max());

            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > minNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine(maxNumber);


            //Average
            Console.WriteLine(numbers.Average());

            double sumForAverage = 0;
            double average = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumForAverage += numbers[i];
                average = sumForAverage / numbers.Count;
            }
            Console.WriteLine(average);


            //x => ... (Lanmbda expression, inline method without a name,acept x, return ...)


            //All
            Console.WriteLine(
                string.Join(" ", numbers.All(x => x > 0)));

            bool allAreZero = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    allAreZero = true;
                }
            }
            Console.WriteLine(allAreZero);


            //Any
            Console.WriteLine(
                string.Join(" ", numbers.Any(x => x % 2 != 0)));

            bool anyAreOdd = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    anyAreOdd = true;
                }
            }
            Console.WriteLine(anyAreOdd);


            //Skip
            Console.WriteLine(string.Join(" ", numbers.Skip(2)));

            //Take
            Console.WriteLine(string.Join(" ", numbers.Take(2)));

            //OrderBy
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x))); //.Sort

            //OrderByDesceding
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));


            //Where
            Console.WriteLine(
                string.Join(" ", numbers.Where(x => x % 2 == 0)));

            Console.WriteLine(
                   string.Join(" ", numbers.Where(x => x % 2 != 0)));

            Console.WriteLine(
                   string.Join(" ", numbers.Where(x => x > 5)));


            //Add
            numbers.Add(5);
            Console.WriteLine(numbers); //out of range


            //AddRange
            numbers.AddRange(new int[] { 6, 7, 8 }); //out of range
            Console.WriteLine(numbers);


            //Select
            Console.WriteLine(
                string.Join(" ", numbers.Select(x => x / 2)));

            numbers[2] = 100;  //List<T> is mutable
                               //Generic Type

            //Random
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(1, 11);
            }
            Console.WriteLine(string.Join(" ",nums));

            //For Shift Left
            static void ShiftListLeft(List<int> numbers, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    int firstNumber = numbers[0]; //Always take first number
                    numbers.RemoveAt(0); //Remove first number
                    numbers.Add(firstNumber);
                }
                Console.WriteLine(string.Join(" ", numbers));
            }

            //For Sift Right
            static void ShiftListRight(List<int> numbers, int count)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int lastNumber = numbers[numbers.Count - 1]; //Always take last number
                    numbers.RemoveAt(numbers.Count - 1); //Remove last number
                    numbers.Insert(0, lastNumber);
                }
                Console.WriteLine(string.Join(" ",numbers));
            }

            static List<int> MethodWithOneReturnButTwoThings()
            {
                return new List<int>() { 1, 2, 3, 4, 5 };
            }

            //Just to see it
            //Extension method on List<int>
            //First parameter -> List<int>
            //static void Shift(this List<int> numbers, string direction, int count)
            //{
            //    if (direction == "Left")
            //    {
            //        for (int i = 0; i < count; i++)
            //        {
            //            int firstNumber = numbers[0]; //Always take first number
            //            numbers.RemoveAt(0); //Remove first number
            //            numbers.Add(firstNumber);
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < count; i++)
            //        {
            //            int lastNumber = numbers[numbers.Count - 1]; //Always take last number
            //            numbers.RemoveAt(numbers.Count - 1); //Remove last number
            //            numbers.Insert(0, lastNumber);
            //        }
            //    }
            //}
        }
    }
}