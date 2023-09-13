using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y
            int countOfTarget = 0;
            double fiftyPercent = power * 0.5;

            while (power >= distance)
            {
                power -= distance;
                countOfTarget++;

                if (fiftyPercent == power && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(countOfTarget);
        }
    }
}