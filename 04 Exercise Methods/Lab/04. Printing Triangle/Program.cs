using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) //rows
            {
                PrintColumns(i);
            }
            for (int i = number - 1; i >= 1; i--) //rows
            {
                PrintColumns(i);
            }
        }

        private static void PrintColumns(int i)
        {
            for (int j = 1; j <= i; j++) //cols
            {

                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

    }
}





//static void Main(string[] args)
//{
//    PrintTriangle(int.Parse(Console.ReadLine()));
//}
//static void PrintLine(int start, int end)
//{
//    for (int i = start; i <= end; i++)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}
//static void PrintTriangle(int n)
//{
//    for (int line = 1; line <= n; line++)
//    {
//        PrintLine(1, line);
//    }
//    for (int line = n - 1; line >= 1; line--)
//    {
//        PrintLine(1, line);
//    }


