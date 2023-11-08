using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());

            PrintGrade(grades);
        }

        private static void PrintGrade(double grades)
        {
            if (grades >= 2 && grades <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.50 && grades <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
