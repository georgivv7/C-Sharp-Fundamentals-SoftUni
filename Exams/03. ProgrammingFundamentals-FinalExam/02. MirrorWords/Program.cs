using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> mirrorWords = new List<string>();
            string pattern = @"([#@])(?<wordOne>[A-Za-z]{3,})\1{2}(?<wordTwo>[A-Za-z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            foreach (Match match in matches)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string wordTwo = match.Groups["wordTwo"].Value;
                string reverse = string.Empty;
                for (int i = wordOne.Length - 1; i >= 0; i--)
                {
                    reverse += wordOne[i];
                }
                if (wordTwo == reverse)
                {
                    mirrorWords.Add(wordOne + " <=> " + reverse);
                }

            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(String.Join(", ", mirrorWords));
            }
        }
    }
}
