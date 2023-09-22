using System;
using System.Linq;
using System.Collections.Generic;

 namespace _03._Magic_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = Console.ReadLine()
                 .Split(":")
                 .ToList();
            var newDeck = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "Ready")
            {
                string[] cmdArgs = input
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];         

                if (cmdType == "Add")
                {
                    string cardName = cmdArgs[1];
                    if (deck.Contains(cardName))
                    {                       
                       newDeck.Add(cardName);                                              
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (cmdType == "Insert")
                {
                    string cardName = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if (deck.Contains(cardName) && (index >= 0 && index < newDeck.Count))
                    {                        
                            newDeck.Insert(index, cardName); 
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (cmdType == "Remove")
                {
                    string cardName = cmdArgs[1];
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                    continue;
                }
                else if (cmdType == "Swap")
                {
                    string cardName = cmdArgs[1];
                    string newCardName = cmdArgs[2];
                    if (cardName != newCardName)
                    {
                        int indexOne = newDeck.IndexOf(cardName);
                        int indexTwo = newDeck.IndexOf(newCardName);

                        string tmp = newDeck[indexOne];
                        newDeck[indexOne] = newDeck[indexTwo];
                        newDeck[indexTwo] = tmp;
                    }
                    continue;
                }

                else if (cmdType == "Shuffle")
                {
                    string cmdType2 = cmdArgs[1];
                    if (cmdType2 == "deck")
                    {
                        newDeck.Reverse();
                    }              
                }
            }
           Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
