using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");
            string text = Console.ReadLine();

            foreach (var currBannedWord in bannedWords)
            {
                text = text.Replace(
                    currBannedWord,
                    new string('*', currBannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
