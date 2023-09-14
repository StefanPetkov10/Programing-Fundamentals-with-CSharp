using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] Arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int ExistElement = 0;

            bool isExistElement = true;
            for (int i = 0; i < Arr.Length; i++)
            {
                int CurrentIndex = i;

                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += Arr[j];
                }
                for (int k = i + 1; k < Arr.Length; k++)
                {
                    rightSum += Arr[k];
                }
                if (leftSum == rightSum)
                {
                    ExistElement = CurrentIndex;
                    isExistElement = true;
                    break;
                }
                else
                {
                    isExistElement = false;
                }
            }
            if (isExistElement)
            {
                Console.WriteLine(ExistElement);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

            //int[] num = Console.ReadLine()
            //     .Split(' ')
            //     .Select(int.Parse)
            //     .ToArray();

            //if (num.Length == 1)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}
            //int leftSum = 0;
            //int rightSum = 0;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    leftSum = num.Take(i).Sum();

            //    rightSum = num.Skip(i + 1).Sum();

            //    if (leftSum == rightSum)
            //    {
            //        Console.WriteLine(i);
            //        return;
            //    }
            //}
            //Console.WriteLine("no");
    