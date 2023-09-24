using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._1_The_Pianist
{
    class Program
    {
        //Гърми в judge

        static void Main(string[] args)
        {
            //key -> Pieces
            //value -> "composer:key"
            Dictionary<string, Dictionary<string, string>> pieces
                = new Dictionary<string, Dictionary<string, string>>();

            int n = int.Parse(Console.ReadLine());
            //"{piece}|{composer}|{key}".
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new Dictionary<string, string>());
                    pieces[piece].Add(composer, key);
                }
            }

            //· "Add|{piece}|{composer}|{key}":
            //· "Remove|{piece}":
            //· "ChangeKey|{piece}|{new key}":

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] comandInfo = command.Split('|');
                string action = comandInfo[0];

                if (action == "Add")
                {
                    string piece = comandInfo[1];
                    string composer = comandInfo[2];
                    string key = comandInfo[3];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new Dictionary<string, string>());
                        pieces[piece].Add(composer, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = comandInfo[1];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string piece = comandInfo[1];
                    string newKey = comandInfo[2];

                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        //Moonlight Sonata|Beethoven|C# Minor
                        //["Moonlight Sonata", "Beethoven:C# Minor"]

                        Dictionary<string, string> currentPiece = 
                            pieces[piece];

                        foreach (var item in currentPiece)
                        {
                            currentPiece[item.Key] = newKey;
                        }

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }
            }

            foreach (var piece in pieces)
            {
                Dictionary<string, string> piecesValue = piece.Value;

                foreach (var item in piecesValue)
                {
                    Console.WriteLine($"{piece.Key} -> Composer: {item.Key}, Key: {item.Value}");
                }
            }

            //"{Piece} -> Composer: {composer}, Key: {key}"
        }
    }
}
