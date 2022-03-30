using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"[sStTaArR]";
                var matches = Regex.Matches(input, pattern);
                int count = matches.Count;
                string decrypted = string.Empty;
                foreach (var item in input)
                {
                    decrypted += (char)(item - count);
                }

                string pattern2 = @"[^@\-:!>]*@(?<name>[A-Za-z]+)([^@\-:!>])*:(?<population>[\d]+)([^@\-:!>])*!(?<attackType>[AD])!([^@\-:!>])*->(?<soldierCount>[\d]+)";
                var planetsData = Regex.Matches(decrypted, pattern2);

                foreach (Match match in planetsData)
                {
                    if (match.Groups["attackType"].Value == "A")
                    {
                        attacked.Add(match.Groups["name"].Value);
                    }
                    else if (match.Groups["attackType"].Value == "D")
                    {
                        destroyed.Add(match.Groups["name"].Value);
                    }
                }

            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count > 0)
            {
                foreach (var item in attacked.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                foreach (var item in destroyed.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            


        }
    }
}
