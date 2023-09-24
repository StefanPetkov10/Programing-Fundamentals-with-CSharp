using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([U][$])(?<username>[A-Z][a-z]{2,})(\1).*?([P][@][$])(?<password>[A-Za-z]{5,}[A-Za-z0-9]*?\d)(\3)";

            int number = int.Parse(Console.ReadLine());
            int validRegCount = 0;

            for (int i = 0; i < number; i++)
            {
                string regex = Console.ReadLine();

                Match match = Regex.Match(regex, pattern);

                if (match.Success)
                {
                    Console.WriteLine($"Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["username"].Value}, Password: {match.Groups["password"].Value}");
                    validRegCount++;
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {validRegCount}");
        }
    }
}