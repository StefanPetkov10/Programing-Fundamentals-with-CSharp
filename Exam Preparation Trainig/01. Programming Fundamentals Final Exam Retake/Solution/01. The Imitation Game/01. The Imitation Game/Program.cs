using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command
                     .Split("|"/*, StringSplitOptions.RemoveEmptyEntries*/);

                string cmdType = cmdArgs[0];
                if (cmdType == "Move")
                {
                    int moveIndex = int.Parse(cmdArgs[1]);
                    string lastLetters = input.Substring(0, moveIndex);
                    string firstLetters = input.Substring(moveIndex);
                    input = firstLetters + lastLetters;
                }
                else if (cmdType == "Insert")
                {
                    int Insertindex = int.Parse(cmdArgs[1]);
                    string letter = cmdArgs[2];
                    input = input.Insert(Insertindex, letter);

                }
                else if (cmdType == "ChangeAll")
                {
                    string currLetter = cmdArgs[1]; //substring
                    string newLetter = cmdArgs[2]; //replacement
                    input = input.Replace(currLetter, newLetter);
                }
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
