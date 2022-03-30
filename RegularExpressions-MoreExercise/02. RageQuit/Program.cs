using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<string>[^\d]+)(?<number>\d+)";
            StringBuilder sb = new StringBuilder();
            int count = 0;
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                string currentString = match.Groups["string"].Value.ToUpper();
                int repeat = int.Parse(match.Groups["number"].Value);
                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(currentString);
                }
            }
            count = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine($"{sb}");
        }
    }
}
