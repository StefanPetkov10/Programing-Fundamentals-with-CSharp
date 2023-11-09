using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();

            int[] specialNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < numbers.Count; i++)
            {
                int specialBombNumber = specialNumbers[0];
                int power = specialNumbers[1];

                if (numbers.Contains(specialBombNumber))
                {
                    int index = numbers.IndexOf(specialBombNumber);
                    int detonationStart = index - power;

                    for (int j = detonationStart; j < index; j++)
                    {
                        if (j < numbers.Count && j >= 0)
                        {
                            numbers.Remove(numbers[j]);
                            numbers.Insert(j, 0);
                        }
                    }
                    int detonationEnd = index + power;
                    for (int k = index + 1; k <= detonationEnd; k++)
                    {
                        if (k < numbers.Count && k >= 0)
                        {
                            numbers.Remove(numbers[k]);
                            numbers.Insert(k, 0);
                        }
                    }
                }
                numbers.Remove(specialBombNumber);
            }
            Console.WriteLine(string.Join(" ", numbers.Where(x => x != 0).Sum()));
        }
    }
}



//            List<int> numbers = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToList();

//            List<int> bombComand = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToList();

//            int bombNumber = bombComand[0];
//            int bombPower = bombComand[1];

//            for (int i = 0; i < numbers.Count; i++)
//            {
//                if (numbers[i] == bombNumber)
//                {
//                    for (int j = 0; j < bombPower * 2 + 1; j++)
//                    {
//                        if (i - bombPower >= 0 && i - bombPower < numbers.Count)
//                        {
//                            numbers.RemoveAt(i - bombPower);
//                        }
//                        else
//                        {
//                            break;
//                        }
//                    }
//                }
//            }

//            int sum = 0;

//            for (int i = 0; i < numbers.Count; i++)
//            {
//                sum += numbers[i];
//            }

//            Console.WriteLine(sum);
//        }
//    }
//}

