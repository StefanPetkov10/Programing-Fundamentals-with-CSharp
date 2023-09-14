using System;
using System.Linq;

namespace _07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currMaxSequence = 1;
            int topMaxSequence = 0;
            int currNum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    currMaxSequence++;
                }
                else
                {
                    currMaxSequence = 1;
                }

                if (currMaxSequence > topMaxSequence)
                {
                    topMaxSequence = currMaxSequence;
                    currNum = numbers[i];
                }
            }
            for (int j = 1; j <= topMaxSequence; j++)
            {
                Console.Write($"{currNum} ");
            }
        }
    }
}
              
  