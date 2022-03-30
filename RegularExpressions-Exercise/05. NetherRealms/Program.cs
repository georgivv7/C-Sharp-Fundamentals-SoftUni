using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, double>> demons = new Dictionary<string, Dictionary<double, double>>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string patternHealth = @"(?<health>[^\d\+\-*\/\.])";
            string patternDamage = @"(?<damage>[+-]?\d+\.?\d*)";
            string patternType = @"(?<type>[*\/])";
            double health = 0;
            double damage = 0;
            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection matches = Regex.Matches(input[i], patternHealth);
                health = 0;
                foreach (Match item in matches)
                {
                    char current = char.Parse(item.Groups["health"].Value);
                    health += current;
                }
                MatchCollection damages = Regex.Matches(input[i], patternDamage);
                damage = 0;
                foreach (Match match in damages)
                {
                    double current = double.Parse(match.Groups["damage"].Value);
                    damage += current;
                }
                MatchCollection types = Regex.Matches(input[i], patternType);
                foreach (Match match in types)
                {
                    if (match.Groups["type"].Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (match.Groups["type"].Value == "/")
                    {
                        damage /= 2;
                    }
                }

                if (demons.ContainsKey(input[i]) == false)
                {
                    demons.Add(input[i], new Dictionary<double, double> { { health, damage } });
                }

            }
            if (demons.Count > 0)
            {
                foreach (var item in demons.OrderBy(x => x.Key))
                {
                    foreach (var elem in item.Value)
                    {
                        Console.WriteLine($"{item.Key} - {elem.Key} health, {elem.Value:F2} damage");
                    }
                }
            }

        }
    }
}
