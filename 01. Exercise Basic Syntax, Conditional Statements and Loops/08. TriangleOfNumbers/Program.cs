using System;

namespace _08._TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Outer loop represents rows
            for (int row = 1; row <= n; row++)
            {
                //Neasted loop represents columns
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }         
        }
    }
}
