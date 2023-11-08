using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calucalations = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculations(calucalations, num1, num2);
        }

        private static void Calculations(string calucalations, int num1, int num2)
        {
            if (calucalations == "add")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (calucalations == "substract")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (calucalations == "multiply")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (calucalations == "divide")
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}
