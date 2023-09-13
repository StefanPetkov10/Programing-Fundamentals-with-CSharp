using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            BigInteger  totalSpices = 0;
            int workingDays = 0;
            BigInteger yield = startingYield;

            if (yield >= 100)
                {
                while (yield >= 100)
                {
                    totalSpices += yield - 26;
                    yield -= 10;
                    workingDays++;
                }

                Console.WriteLine(workingDays);
                Console.WriteLine(totalSpices - 26);
            }
            else
            {
                Console.WriteLine(workingDays);
                Console.WriteLine(totalSpices);
            }
        }
    }
}
