using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandParams = input.Split();
                string command = commandParams[0];

                if (command == "Delete")
                {
                    int value = int.Parse(commandParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(commandParams[1]);
                    int index = int.Parse(commandParams[2]);

                    numbers.Insert(index, value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
