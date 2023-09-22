using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            string input;
            int moves = 0;
            string numberToAdd = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                string[] inputArgs = input.Split();
                int index1 = int.Parse(inputArgs[0]);
                int index2 = int.Parse(inputArgs[1]);

                moves++;

                if (index1 == index2 ||
                    index1 < 0 ||
                    index1 > numbers.Count ||
                    index2 < 0 ||
                    index2 > numbers.Count)
                {
                    numberToAdd = $"-{moves}a";

                    numbers.Insert(numbers.Count / 2, numberToAdd);
                    numbers.Insert((numbers.Count / 2) + 1, numberToAdd);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (numbers[index1] == numbers[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");

                    if (index1 < index2)
                    {
                        numbers.RemoveAt(index1);
                        numbers.RemoveAt(index2 - 1);
                    }
                    else if (index1 > index2)
                    {
                        numbers.RemoveAt(index1);
                        numbers.RemoveAt(index2);
                    }
                }
                else if (numbers[index1] != numbers[index2])
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (input == "end" && numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}