using System;

namespace _01._Easter
{
    class Program
    {
        static void Main(string[] args)
        {
            string easter = Console.ReadLine();

            string comannd = string.Empty;
            while ((comannd = Console.ReadLine()) != "Easter")
            {
                string[] cmdArgs = comannd
                     .Split(" "/*, StringSplitOptions.RemoveEmptyEntries*/);
                string cmdType = cmdArgs[0];

                if (cmdType == "Replace")
                {
                    string oldChar = cmdArgs[1];
                    string newChar = cmdArgs[2];
                   
                        easter = easter.Replace(oldChar, newChar);
                        Console.WriteLine(easter);
                    
                }
                else if (cmdType == "Remove")
                {
                    string substring = cmdArgs[1];
                    int index = easter.IndexOf(substring);
                    if (index >= 0 && index < easter.Length)
                    {
                        easter = easter.Remove(index, substring.Length);
                        Console.WriteLine(easter);
                    }
                    else
                    {
                        Console.WriteLine(easter);
                    }

                }
                else if (cmdType == "Includes")
                {
                    string substring = cmdArgs[1];
                    if (easter.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdType == "Change")
                {
                    string cmdTypeLetters = cmdArgs[1];
                    if (cmdTypeLetters == "Upper")
                    {
                        easter = easter.ToUpper();
                        Console.WriteLine(easter);
                    }
                    else if (cmdTypeLetters == "Lower")
                    {
                        easter = easter.ToLower();
                        Console.WriteLine(easter);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdType == "Reverse")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex >= 0 && startIndex < easter.Length && endIndex >= 0 && endIndex < easter.Length)
                    {
                        char[] cArray = easter.ToCharArray();
                        string revers = string.Empty;

                        for (int i = endIndex; i >= startIndex; i--)
                        {
                            revers += cArray[i];
                        }
                        Console.WriteLine(revers);
                    }
                        
                }

            }
        }
    }
}
