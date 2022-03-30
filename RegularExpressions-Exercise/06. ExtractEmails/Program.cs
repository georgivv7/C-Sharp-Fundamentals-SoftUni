using System;
using System.Text.RegularExpressions;

namespace _06._ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)([A-Za-z0-9]+[.-]*\w*)*@([a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";

            var matches = Regex.Matches(input, pattern);

            Console.WriteLine(String.Join(Environment.NewLine,matches));
        }
    }
}
