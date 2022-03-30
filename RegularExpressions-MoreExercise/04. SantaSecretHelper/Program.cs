using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._SantaSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<string> children = new List<string>();
            string pattern = @"@(?<name>[A-Za-z]+)([^-@!:>]*)!(?<behaviour>[G])!";
            while ((input=Console.ReadLine())!="end")
            {
                string decrypted = "";
                for (int i = 0; i < input.Length; i++)
                {
                    char current = input[i];
                    current -= (char)key;
                    decrypted += current;
                }
                Match match = Regex.Match(decrypted, pattern);
                string name = match.Groups["name"].Value;
                if (children.Contains(name)==false)
                {
                    children.Add(name);
                }

            }

            foreach (var name in children)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
