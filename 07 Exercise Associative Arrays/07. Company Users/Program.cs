using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInfo =
                new Dictionary<string, List<string>>();

            string company;
            while ((company = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = company
                     .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string id = cmdArgs[1];

                if (!companyInfo.ContainsKey(companyName))
                {
                    companyInfo.Add(companyName, new List<string>());
                }
                if (!companyInfo[companyName].Contains(id))
                {
                    companyInfo[companyName].Add(id);
                }
            }

            foreach (var kvp in companyInfo)
            {
                string companyName = kvp.Key;
                List<string> idN = kvp.Value;

                Console.WriteLine($"{companyName}");
                foreach (string id in idN)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
