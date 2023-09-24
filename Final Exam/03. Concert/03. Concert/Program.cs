using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            int totalTime = 0;

            var input = new List<string>();

            var bandTime = new Dictionary<string, int>();
            var bandMembers = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "Start!")
            {
                input = command.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string cmdType = input[0];
                string band = input[1];

                if (cmdType == "Add")
                {
                    List<string> members = input[2]
                        .Split(", ")
                        .ToList();

                    if (!bandMembers.ContainsKey(band))
                    {
                        bandMembers.Add(band, new List<string>());
                    }

                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bandMembers[band].Contains(members[i]))
                        {
                            bandMembers[band].Add(members[i]);
                        }
                    }
                }

                else if (cmdType == "Play")
                {
                    int time = int.Parse(input[2]);
                    if (time >= 0)
                    {
                       
                        if (!bandTime.ContainsKey(band))
                        {
                            bandTime.Add(band, time);
                        }
                        else
                        {
                            bandTime[band] += time;
                        }
                        totalTime += time;
                    }

                }
            }
            string finalLine = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime} ");
            foreach (var item in bandTime)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var kvp in bandMembers)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"=> {item}");
                }
                break;

            }

        }
    }
}