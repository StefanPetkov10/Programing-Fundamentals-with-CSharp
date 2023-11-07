using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
             
            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }

            //Back to front crawl

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    int currentNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = currentNumber;
            //}
            //Console.Write(string.Join(' ', numbers));


            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    var temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = temp;
            //}
            //Console.Write(string.Join(' ', numbers));


            //using System.Linq;
            //int num = int.Parse(Console.ReadLine());
            //int[] numbers = new int[num];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   numbers[i] = int.Parse(Console.ReadLine());          
            //}
            //Console.Write(string.Join(' ', numbers.Reverse()));
        }
    }
}
