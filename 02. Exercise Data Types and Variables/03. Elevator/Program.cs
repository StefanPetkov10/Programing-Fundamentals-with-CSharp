﻿using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacityOfPeole = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / capacityOfPeole);

            if (people < capacityOfPeole)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(courses);
            }

        }
    }
}