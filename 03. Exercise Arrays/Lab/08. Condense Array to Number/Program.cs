using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray() ;
            int count = array.Length;

            while (count > 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i] + array[i + 1];
                }
                count--;
            }
            Console.WriteLine(array[0]);
        }
    }
}
