using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string text = Console.ReadLine();

            //string result = text.Replace(specialWord, string.Empty);

            while (text.Contains(specialWord))
            {
                int startIndex = text.IndexOf(specialWord);

                text = text.Remove(startIndex, specialWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}
