using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split("<->");
                string name = info[0];
                int rarity = int.Parse(info[1]);
                if (plants.ContainsKey(name) == false)
                {
                    plants.Add(name, rarity);
                    ratings.Add(name, new List<double>());
                }
                else
                {
                    plants[name] = rarity;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArray = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string leftCommand = commandArray[0];
                var rightCommand = commandArray[1].Trim().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string plant = rightCommand[0].Trim();

                if (plants.ContainsKey(plant) == false)
                {
                    Console.WriteLine("error");
                }
                else if (ratings.ContainsKey(plant))
                {
                    switch (leftCommand)
                    {
                        case "Rate":
                            double rating = double.Parse(rightCommand[1]);
                            ratings[plant].Add(rating);
                            break;
                        case "Update":
                            int newRarity = int.Parse(rightCommand[1]);
                            plants[plant] = newRarity;
                            break;
                        case "Reset":
                            ratings[plant].Clear();
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
               
            }

            Dictionary<string, List<double>> sorted = new Dictionary<string, List<double>>();
            foreach (var item in ratings.OrderByDescending(x => x.Value.Count > 0 ? x.Value.Average() : 0))
            {
                string plant = item.Key;
                double resultRating = item.Value.Count > 0 ? item.Value.Average() : 0;
                int rarity = plants[plant];
                double rarityDouble = (double)rarity;
                sorted[plant] = new List<double>();
                sorted[plant].Add(rarityDouble);
                sorted[plant].Add(resultRating);
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in sorted.OrderByDescending(x => x.Value[0]))
            {
                string plant = item.Key;
                double rarity = item.Value[0];
                double resultRating = item.Value[1];
                Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {resultRating:f2}");
            }
        }
    }
}
