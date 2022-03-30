using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Rankings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, string> contestData = new Dictionary<string, string>();
            SortedDictionary<string,Dictionary<string,int>> contestPoints = new SortedDictionary<string,Dictionary<string,int>>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(':');
                string contestName = data[0];
                string password = data[1];

                contestData.Add(contestName, password);

            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input.Split("=>");
                string contestName = data[0]; 
                string password = data[1]; 
                string user = data[2]; 
                int points = int.Parse(data[3]);

                if (contestData.ContainsKey(contestName)==false)
                {
                    continue;
                }
                else if(contestData.ContainsKey(contestName)&&contestData.ContainsValue(password))
                {
                    if (contestPoints.ContainsKey(user)==false)
                    {
                        contestPoints.Add(user, new Dictionary<string, int> { { contestName, points } });                       
                    }
                    if (contestPoints[user].ContainsKey(contestName)==false)
                    {
                        contestPoints[user].Add(contestName, points);
                    }
                    if (contestPoints[user][contestName] < points)
                    {
                        contestPoints[user][contestName] = points;
                    }
                }
            }
            Dictionary<string, int> usersTotalPoints = new Dictionary<string, int>();

            foreach (var item in contestPoints)
            {
                usersTotalPoints[item.Key] = item.Value.Values.Sum();
            }
            int maxPoints = usersTotalPoints.Values.Max();
            foreach (var item in usersTotalPoints)
            {
                if (item.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                }
            }
            Console.WriteLine($"Ranking: ");
            foreach (var item in contestPoints)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine(string.Join(Environment.NewLine, item.Value
                    .OrderByDescending(x => x.Value)
                    .Select(s => $"#  {s.Key} -> {s.Value}")));
            }
        }
    }
}
