using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            string result = string.Empty; 

            foreach (var currentWord in words)
            {
                for (int i = 0; i < currentWord.Length; i++)
                {
                    result += currentWord;
                }
            }
            Console.WriteLine(result);
        }
    }
}
