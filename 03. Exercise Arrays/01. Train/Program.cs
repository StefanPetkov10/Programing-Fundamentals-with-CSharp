using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            int sum = 0;
          
            for (int i = 0; i < num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
              
                sum += currentNumber;
            }
            foreach (int item in numbers)
            {
                Console.Write(item + " ");       
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
