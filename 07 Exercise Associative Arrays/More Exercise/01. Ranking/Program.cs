using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            char[] chars = { ':', '=', '>' };

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArguments = input.Split(":");

                string contest = inputArguments[0];
                string password = inputArguments[1];

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }
            }
            Dictionary<string, Dictionary<string, double>> users = new Dictionary<string, Dictionary<string, double>>();

            string commands;

            while ((commands = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArguments = commands.Split("=>");

                string contest = cmdArguments[0];
                string password = cmdArguments[1];
                string userName = cmdArguments[2];
                double points = double.Parse(cmdArguments[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(userName))
                    {
                        users[userName] = new Dictionary<string, double>();
                    }

                    if (!users[userName].ContainsKey(contest))
                    {
                        users[userName][contest] = 0;
                    }

                    if (users[userName][contest] < points)
                    {
                        users[userName][contest] = points;

                    }
                }
            }
            string winner = users.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            double bestPoints = users.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var user in users.OrderBy(w => w.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var (contest, point) in user.Value.OrderByDescending(point => point.Value))
                {
                    Console.WriteLine($"#  {contest} -> {point}");
                }
            }
        }
    }
}