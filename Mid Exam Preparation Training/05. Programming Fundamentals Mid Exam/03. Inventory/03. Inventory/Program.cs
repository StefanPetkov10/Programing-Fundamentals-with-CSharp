using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Craft!")
                {
                    break;
                }

                string[] partsCommand = line.Split(" - ");

                string command = partsCommand[0];
                string item = partsCommand[1];

                if (command == "Collect")
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                        ;
                    }

                    continue;
                }

                else if (command == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }

                    continue;
                }

                else if (command == "Combine Items")
                {
                    string[] itemsToCombine = item.Split(":");

                    string oldItem = itemsToCombine[0];

                    string newItem = itemsToCombine[1];

                    if (items.Contains(oldItem))
                    {
                        items.Insert((items.IndexOf(oldItem) + 1), newItem);
                    }
                    continue;
                }

                else if (command == "Renew")
                {
                    if (items.Contains(item))
                    {
                        int itemIdx = items.IndexOf(item);
                        items.Add(item);
                        items.RemoveAt(itemIdx);
                    }
                }
            }

            Console.Write(string.Join(", ", items));
        }
    }
}