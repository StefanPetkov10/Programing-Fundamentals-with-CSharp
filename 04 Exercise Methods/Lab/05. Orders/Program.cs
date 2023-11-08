using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            

            Orders(product, quantity);

        }

        private static void Orders(string product, int quantity)
        {
            double price = 0.00;
            double sum = 0.00;

            if (product == "coffee")
            {
                price = 1.50;
                sum = price * quantity;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "water")
            {
                price = 1.00;
                sum = price * quantity;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "coke")
            {
                price = 1.40;
                sum = price * quantity;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "snacks")
            {
                price = 2.00;
                sum = price * quantity;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
