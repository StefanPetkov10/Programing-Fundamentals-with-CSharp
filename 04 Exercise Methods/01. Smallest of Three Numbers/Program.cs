using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = GetMin(num1, num2, num3);
            Console.WriteLine(result);
        }
        static int GetMin(int a, int b, int c)
        {

            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        
    }
}
