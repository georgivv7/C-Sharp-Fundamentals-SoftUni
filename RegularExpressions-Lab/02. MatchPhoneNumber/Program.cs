using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"(\+359)([ -])2(\2)(\d{3})(\2)(\d{4})\b";
            MatchCollection matches = Regex.Matches(phoneNumbers, pattern);
            List<string> validNumbers = new List<string>();

            foreach (Match match in matches)
            {
                validNumbers.Add(match.Value);
            }
            Console.WriteLine(String.Join(", ", validNumbers));
        }
    }
}
