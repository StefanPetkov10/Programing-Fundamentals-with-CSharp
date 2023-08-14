using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int factorialSum = 0;

            while(numCopy > 0)
            {
                int lastDigit = numCopy % 10; //The last digit
                numCopy /= 10; //Remove the taken digit

                int factorial = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }
            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
