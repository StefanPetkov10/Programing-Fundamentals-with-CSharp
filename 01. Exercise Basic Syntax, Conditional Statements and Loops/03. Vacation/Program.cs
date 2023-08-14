using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Friday":
                    if(typeOfGroup == "Students")
                    {
                        price = groupOfPeople * 8.45;
                        if(groupOfPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = groupOfPeople * 10.9;
                        if (groupOfPeople >= 100)
                        {
                            price -= 10 * 10.9;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = groupOfPeople * 15;
                        if (groupOfPeople >= 10 && groupOfPeople <=20)
                        {
                            price *= 0.95;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                   break;

                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        price = groupOfPeople * 9.80;
                        if (groupOfPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = groupOfPeople * 15.60;
                        if (groupOfPeople >= 100)
                        {
                            price -= 10 * 15.6;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = groupOfPeople * 20;
                        if (groupOfPeople >= 10 && groupOfPeople <= 20)
                        {
                            price *= 0.95;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;

                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        price = groupOfPeople * 10.46;
                        if (groupOfPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = groupOfPeople * 16;
                        if (groupOfPeople >= 100)
                        {
                            price -= 10 * 16;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = groupOfPeople * 22.50;
                        if (groupOfPeople >= 10 && groupOfPeople <= 20)
                        {
                            price *= 0.95;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
            }

        }
    }
}
