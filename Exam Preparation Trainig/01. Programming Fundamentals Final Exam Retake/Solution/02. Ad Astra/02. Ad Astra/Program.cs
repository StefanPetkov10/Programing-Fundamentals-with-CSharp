using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(#|\|)(?<name>[A-Za-z\s]+)(\1)(?<date>(\d{2}/\d{2}/\d{2}))(\1)(?<calories>(\d+))\1";

            int totalCalories = 0;

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalCalories += calories;
            }
            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match group in matches)
            {
                string name = group.Groups["name"].Value;
                string date = group.Groups["date"].Value;
                int calories = int.Parse(group.Groups["calories"].Value);

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
