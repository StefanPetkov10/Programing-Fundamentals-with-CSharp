using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"(=|\/)(?<name>([A-Z][A-Za-z]{2,}))\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputText);

            int destination = 0;
            foreach (Match match in matches)
            {
                int pointsDestination = match.Groups["name"].Length;

                destination += pointsDestination;
                //foreach (char ch in nameDestination)
                //{
                //    if (char.IsLetter(ch))
                //    {
                //        destination++;
                //    }
                //}
            }
            Console.WriteLine($"Destinations: {String.Join(", ", matches.Select(n => n.Groups["name"].Value))}");
            Console.WriteLine($"Travel Points: {destination}");
        }
    }
}
