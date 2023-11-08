using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, operation, num2);
            Console.WriteLine(result);
        }
        private static double Calculate(double a, string @operation, double b)
        {
            double result = 0.00;

            if (operation == "+")
            {
                result = a + b;     
            }

            else if (operation == "-")
            {
                result = a - b;
            }

            else if (operation == "*")
            {
                result = a * b;
            }

            else if (operation == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}
