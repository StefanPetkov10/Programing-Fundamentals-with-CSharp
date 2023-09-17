using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = 0;
            int substract = 0;

            sum = SumInteger(num1, num2);
            substract = SubstractInteger(num3, sum);

            Console.WriteLine(substract);

        }
        private static int SumInteger(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int SubstractInteger(int num3, int sum)
        {
            return sum - num3;
        }

    }
}
