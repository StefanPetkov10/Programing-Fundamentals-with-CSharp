using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial1 = int.Parse(Console.ReadLine());
            int factorial2 = int.Parse(Console.ReadLine());

            double sumOfFactorial1 = 1;
            double sumOfFactorial2 = 1;

            double divisionOfFactorial = SumOfFactorial1(factorial1, sumOfFactorial1) / SumOfFactorial2(factorial2, sumOfFactorial2);
            Console.WriteLine($"{divisionOfFactorial:f2}");

        }
        private static double SumOfFactorial1(int factorial1, double sumOfFactorial1)
        {
            for (int i = 1; i <= factorial1; i++)
            {
                sumOfFactorial1 *= i;
            }
            return sumOfFactorial1;

        }
        private static double SumOfFactorial2(int factorial2, double sumOfFactorial2)
        {
            for (int i = 1; i <= factorial2; i++)
            {

                sumOfFactorial2 *= i;
            }
            return sumOfFactorial2;

        }
    }
}