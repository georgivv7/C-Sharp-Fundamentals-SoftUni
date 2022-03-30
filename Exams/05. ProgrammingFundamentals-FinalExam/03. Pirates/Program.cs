using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] data = input.Split("||");
                string city = data[0];
                int population = int.Parse(data[1]);
                int gold = int.Parse(data[2]);
                if (cities.ContainsKey(city) == false)
                {
                    cities.Add(city, new int[2]);
                    cities[city][0] = population;
                    cities[city][1] = gold;
                }
                else if (cities.ContainsKey(city))
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }
            }
            string inputs = string.Empty;
            while ((inputs = Console.ReadLine()) != "End")
            {
                string[] commands = inputs.Split("=>");
                string command = commands[0];
                string town = commands[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    cities[town][0] -= people;
                    cities[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cities[town][0] == 0 || cities[town][1] == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                    }
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(commands[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cities[town][1] += gold;
                        int totalGold = cities[town][1];
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");
                    }
                }
            }
            if (cities.Keys.Count > 0)
            {
                int count = cities.Keys.Count;
                Console.WriteLine($"Ahoy, Captain! There are {count} wealthy settlements to go to:");
                foreach (var item in cities.OrderByDescending(x => x.Value[1]).ThenBy(w => w.Key))
                {
                    string town = item.Key;
                    int people = item.Value[0];
                    int gold = item.Value[1];
                    Console.WriteLine($"{town} -> Population: {people} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
