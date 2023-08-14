using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string coin = Console.ReadLine();
            double sumCoin = 0;

            while (coin != "Start")
            {
                switch (coin)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        sumCoin = sumCoin + double.Parse(coin);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }

                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double productPrice = 0;
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (sumCoin >= productPrice && sumCoin > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sumCoin -= productPrice;
                    productPrice = 0;
                }
                else if (sumCoin < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                    productPrice = 0;
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoin:f2}");


        }
    }
}
