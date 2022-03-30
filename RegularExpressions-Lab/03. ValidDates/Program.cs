using System;
using System.Text.RegularExpressions;

namespace _03._ValidDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string pattern = @"\b(?<day>[\d]{2})([-.\/])(?<month>[A-Z][a-z]{2})(\1)(?<year>[\d]{4})\b";
            MatchCollection matches = Regex.Matches(date,pattern);

            foreach (Match dates in matches)
            {
                string day = dates.Groups["day"].Value;
                string month = dates.Groups["month"].Value;
                string year = dates.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
