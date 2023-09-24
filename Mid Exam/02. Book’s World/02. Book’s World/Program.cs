using System;
using System.Linq;

namespace _02._Book_s_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var genre = Console.ReadLine()
                .Split(" | ")
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Stop!")
            {
                string[] cmdArgs = input
                     .Split(" "/*, StringSplitOptions.RemoveEmptyEntries*/);

                string cmdType = cmdArgs[0];

                if (cmdType == "Join")
                {
                    string nameGenre = cmdArgs[1];
                    if(!genre.Contains(nameGenre))
                    { 
                    genre.Add(nameGenre);
                    }
                }
                else if (cmdType == "Drop")
                {
                    string nameGenre = cmdArgs[1];
                    if (genre.Contains(nameGenre))
                    {
                        genre.Remove(nameGenre);
                    }

                }
                else if (cmdType == "Replace")
                {
                    string oldGenre = cmdArgs[1];
                    string newGenre = cmdArgs[2];
                    if (genre.Contains(oldGenre) && !genre.Contains(newGenre))
                    {
                        int oldNameIndex = genre.IndexOf(oldGenre);
                        genre[oldNameIndex] = newGenre;
                    }
                }
                else if (cmdType == "Prefer")
                {
                    int indexOne = int.Parse(cmdArgs[1]);
                    int indexTwo = int.Parse(cmdArgs[2]);
                    if (indexOne >= 0 && indexOne < genre.Count && indexTwo >= 0 && indexTwo < genre.Count)
                    {
                        if (genre.Contains(genre[indexOne]) && genre.Contains(genre[indexTwo]))
                        {
                            string tmp = genre[indexOne];
                            genre[indexOne] = genre[indexTwo];
                            genre[indexTwo] = tmp;
                        }
                    }
                }
            }
           Console.WriteLine(string.Join(" ", genre));
        }
    }
}
