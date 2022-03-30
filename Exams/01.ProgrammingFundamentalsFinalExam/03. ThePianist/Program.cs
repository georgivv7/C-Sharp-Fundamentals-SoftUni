using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (pieces.ContainsKey(piece) == false)
                {
                    pieces.Add(piece, new string[2]);
                    pieces[piece][0] = composer;
                    pieces[piece][1] = key;
                }
            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                var data = command.Split("|");
                string typeOfCommand = data[0];
                ;

                switch (typeOfCommand)
                {
                    case "Add":
                        string piece = data[1];
                        string composer = data[2];
                        string key = data[3];
                        if (pieces.ContainsKey(piece) == false)
                        {
                            pieces.Add(piece, new string[2]);
                            pieces[piece][0] = composer;
                            pieces[piece][1] = key;
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        piece = data[1];
                        if (pieces.ContainsKey(piece) == false)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            continue;

                        }
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                        break;
                    case "ChangeKey":
                        piece = data[1];
                        string newKey = data[2];
                        if (pieces.ContainsKey(piece) == false)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            continue;

                        }
                        pieces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        break;
                }
            }

            foreach (var item in pieces.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
