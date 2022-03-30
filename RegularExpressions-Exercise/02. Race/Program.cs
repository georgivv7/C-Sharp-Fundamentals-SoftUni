using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;
            string namePattern = @"[A-Za-z]";
            string kmPattern = @"\d";
            Dictionary<string, int> rankings = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection matchName = Regex.Matches(input, namePattern);
                MatchCollection matchKm = Regex.Matches(input, kmPattern);

                string name = String.Concat(matchName);
                int sum = matchKm.Select(x => int.Parse(x.Value)).Sum();

                if (racers.Contains(name))
                {
                    if (rankings.ContainsKey(name) == false)
                    {
                        rankings.Add(name, sum);
                    }
                    else if (rankings.ContainsKey(name))
                    {
                        rankings[name] += sum;
                    }
                }

            }

            var sorted = rankings.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
