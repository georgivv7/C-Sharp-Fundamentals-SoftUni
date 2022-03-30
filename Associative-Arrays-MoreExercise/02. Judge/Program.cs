using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> contestData = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] data = input.Split(" -> ");
                string username = data[0];
                string contest = data[1];
                int points = int.Parse(data[2]);

                if (contestData.ContainsKey(contest) == false)
                {
                    contestData.Add(contest, new Dictionary<string, int> { { username, points } });
                }
                if (contestData[contest].ContainsKey(username) == false)
                {
                    contestData[contest].Add(username, points);
                }
                else if (contestData[contest].ContainsKey(username))
                {
                    if (contestData[contest][username] < points)
                    {
                        contestData[contest][username] = points;
                    }
                }
            }
            foreach (var item in contestData)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int position = 1;
                foreach (var elem in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {elem.Key} <::> {elem.Value}");
                    position++;
                }
            }

            Dictionary<string, int> participantTotalPoints = new Dictionary<string, int>();

            foreach (var item in contestData)
            {
                foreach (var elem in item.Value)
                {
                    if (participantTotalPoints.ContainsKey(elem.Key))
                    {
                        participantTotalPoints[elem.Key] += elem.Value;
                    }
                    else
                    {
                        participantTotalPoints[elem.Key] = elem.Value;
                    }

                }

            }

            Console.WriteLine($"Individual standings:");
            int counter = 1;
            foreach (var item in participantTotalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter}. {item.Key} -> {item.Value}");
                counter++;
            }
        }
    }
}
