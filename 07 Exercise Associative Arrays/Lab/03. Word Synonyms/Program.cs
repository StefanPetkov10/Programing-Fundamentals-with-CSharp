using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var synonyms = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}


//static void Main(string[] args)
//{
//    Dictionary<string, Dictionary<string, string>> synonums
//         = new Dictionary<string, Dictionary<string, string>>();

//    var dictForWord = new Dictionary<string, string>();
//    synonums.Add("cute", dictForWord //or new Dictionary<string, string>());
//    synonums["cute"].Add("sth", "else");

//    foreach (var item in synonums)
//    {
//        Console.WriteLine(item.Key);

//        foreach (var val in item.Value)
//        {
//            Console.WriteLine($"{val.Key} - {val.Value}");
//        }
//    }
//}
