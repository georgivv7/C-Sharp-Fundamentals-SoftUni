using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            double totalSpend = 0;
            List<string> furniture = new List<string>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    totalSpend += price * quantity;
                    furniture.Add(match.Groups["name"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, furniture));
            }         
            Console.WriteLine($"Total money spend: {totalSpend:F2}");
        }
    }
}
