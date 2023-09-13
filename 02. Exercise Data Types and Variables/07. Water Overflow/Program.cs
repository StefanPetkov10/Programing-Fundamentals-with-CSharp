using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWater = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int sumWater = 0;

            for (int i = 0; i < countOfWater; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sumWater += liters;

                if (sumWater > waterTank)
                {
                    sumWater -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumWater);                   
        }
    }
}
