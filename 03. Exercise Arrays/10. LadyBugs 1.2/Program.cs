using System;
using System.Linq;

namespace _10._LadyBugs_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] bugs = new int[sizeOfArray];
            int[] bugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                if (bugsIndexes[i] < 0 || bugsIndexes[i] >= bugs.Length)
                {
                    continue;
                }

                bugs[bugsIndexes[i]] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                int bugIndex = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int steps = int.Parse(commandArgs[2]);

                if (bugIndex < 0 || bugIndex >= bugs.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (bugs[bugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                bugs[bugIndex] = 0;

                while (true)
                {
                    if (direction == "right")
                    {
                        bugIndex += steps;
                    }
                    else
                    {
                        bugIndex -= steps;
                    }

                    if (bugIndex < 0 || bugIndex >= bugs.Length)
                    {
                        break;
                    }

                    if (bugs[bugIndex] == 1)
                    {
                        continue;
                    }

                    bugs[bugIndex] = 1;
                    break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", bugs));
        }
    }
}