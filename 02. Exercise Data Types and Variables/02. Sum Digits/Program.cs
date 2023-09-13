using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                int finalDigits = number;
                finalDigits %= 10;
                number /= 10;
                sum += finalDigits;
            }

            while (0 != number);
                {
                   
                }
            Console.WriteLine(sum);
        }
    }
}
