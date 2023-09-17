using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
       
            PrintSolidSquarePattern(row);

        }

        private static void PrintSolidSquarePattern(int row)
        {
            for (int i = 1; i <= row * row; i++)
            {
                if (i % row == 0)
                {
                    Console.WriteLine(row + " ");
                }
                else
                {
                    Console.Write(row + " ");
                }
            }
        }
    }
}
      
