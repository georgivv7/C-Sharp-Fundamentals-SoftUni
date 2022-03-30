﻿using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<name>[A-Z][a-z]+) (?<surname>[A-Z][a-z]+)";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
            
        }
    }
}
