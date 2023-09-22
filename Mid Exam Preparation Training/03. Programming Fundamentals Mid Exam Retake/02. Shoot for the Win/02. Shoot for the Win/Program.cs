using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexTarget = int.Parse(command);

                if (indexTarget >= 0 && indexTarget < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int temp = targets[indexTarget];

                        if (targets[i] != -1 && i != indexTarget)
                        {
                            if (targets[i] > temp)
                            {
                                targets[i] -= temp;
                            }
                            else if (targets[i] <= temp)
                            {
                                targets[i] += temp;

                            }
                        }
                    }
                    targets[indexTarget] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));
        }
    }
}
