using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int points = 0;
            string pattern = @"([=\/])(?<destination>[A-Z][A-Za-z]{2,})\1";
            MatchCollection validDestinations = Regex.Matches(input, pattern);
            List<string> destinations = new List<string>();
            foreach (Match match in validDestinations)
            {
                destinations.Add(match.Groups["destination"].Value);
                points += match.Groups["destination"].Value.Length;
            }


            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
