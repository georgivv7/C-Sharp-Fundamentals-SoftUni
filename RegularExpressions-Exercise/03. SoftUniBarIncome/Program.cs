using System;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double income = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>[0-9]{1,})\|[^|$%.]*?(?<price>\d+(?:.\d+)?)\$$";
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["quantity"].Value) * double.Parse(match.Groups["price"].Value);
                    income += price;
                    Console.WriteLine($"{name}: {product} - {price:f2}");
                }
            }

            Console.WriteLine($"Total income: {income:f2}");



        }
    }
}
