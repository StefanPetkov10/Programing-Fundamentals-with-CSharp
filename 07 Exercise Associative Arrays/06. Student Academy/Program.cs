using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPair = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> listGrades =
                new Dictionary<string, List<double>>();

            string name = string.Empty;
            double grade = 0.00;

            for (int i = 0; i < numberPair; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!listGrades.ContainsKey(name))
                {
                    listGrades[name] = new List<double>();    
                }

                listGrades[name].Add(grade);
            }

            double value = 4.50;

            foreach (var item in listGrades)
            {
                if (item.Value.Average() >= value)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }

        }
    }
}