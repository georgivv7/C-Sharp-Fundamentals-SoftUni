using System;
using System.Text.RegularExpressions;

namespace _02._AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([#|])(?<product>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            int totalCalories = 0;
            int totalDays = 0;
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }
            totalDays = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {totalDays} days!");
            foreach (Match product in matches)
            {
                string name = product.Groups["product"].Value;
                string date = product.Groups["date"].Value;
                int calories = int.Parse(product.Groups["calories"].Value);
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
