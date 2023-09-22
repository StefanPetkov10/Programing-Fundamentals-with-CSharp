using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input
                     .Split(" "/*, StringSplitOptions.RemoveEmptyEntries*/);

                string cmdType = cmdArgs[0];

                if (cmdType == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
                    {
                        int swap = array[index1];
                        array[index1] = array[index2];
                        array[index2] = swap;
                    }
                   
                }
                else if (cmdType == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
                    {
                        int multiply = array[index1] * array[index2];
                        array[index1] = multiply;
                    }
                }
                else if (cmdType == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        int decrease = array[i] - 1;
                        array[i] = decrease;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
