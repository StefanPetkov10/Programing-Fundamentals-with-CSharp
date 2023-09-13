using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegCounter = int.Parse(Console.ReadLine());
            double maxValume = double.MinValue;
            string winKegName = string.Empty;

            for (int i = 0; i < kegCounter; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());

                double valume = Math.PI * (radius * radius) * hight;

                if(valume > maxValume)
                {
                    maxValume = valume;
                    winKegName = kegName;
                }
            }
            Console.WriteLine(winKegName);
        }
    }
}
