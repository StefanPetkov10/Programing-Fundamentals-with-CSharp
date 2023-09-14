using System;
using System.Linq;

namespace Bonus_CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dinamic Length -> Choosed by user input
            //Can not be changed after input
            int[] numbers = Console.ReadLine()
                .Split(", ") //string[]
                .Select(int.Parse) //UnknownCollection<int>
                .ToArray(); //int[]

            //Copy the numbers into another array
            //Own copy algorithm
            int[] copyArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                copyArray[i] = currentNum;
            }

            Console.WriteLine(string.Join(" ", copyArray));
        }
    }
}
