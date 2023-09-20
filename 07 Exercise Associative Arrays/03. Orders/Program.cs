using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> totalPrice = new Dictionary<string, double>();
            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string product = input[0];

                if (totalPrice.ContainsKey(product) && product != "buy")
                {
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);


                    totalPrice[product] = (totalQuantity[product] + quantity) * price;
                    totalQuantity[product] += quantity;
                }
                else if (product != "buy")
                {
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);
                    double PriceforAll = price * quantity;
                    totalQuantity.Add(product, quantity);
                    totalPrice.Add(product, PriceforAll);
                }

                if (product == "buy")
                {
                    foreach (var p in totalPrice)
                    {
                        Console.WriteLine($"{p.Key} -> {p.Value:f2}");
                    }
                    break;
                }

            }
        }
    }
}


