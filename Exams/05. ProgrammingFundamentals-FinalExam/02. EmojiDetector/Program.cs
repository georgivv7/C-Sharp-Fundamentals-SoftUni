using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> cool = new List<string>();
            long coolTreshold = 1;
            int countOfAllEmojis = 0;
            string patternValid = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternDigits = @"\d";
            MatchCollection valid = Regex.Matches(input, patternValid);
            MatchCollection digits = Regex.Matches(input, patternDigits);
            foreach (Match item in digits)
            {
                coolTreshold *= int.Parse(item.Value);
            }
            foreach (Match match in valid)
            {
                string currentMatch = match.Groups["emoji"].Value;
                int totalSum = 0;
                countOfAllEmojis++;
                for (int i = 0; i < currentMatch.Length; i++)
                {
                    totalSum += currentMatch[i];
                }
                if (totalSum > coolTreshold)
                {
                    cool.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{countOfAllEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine, cool));

        }
    }
}
