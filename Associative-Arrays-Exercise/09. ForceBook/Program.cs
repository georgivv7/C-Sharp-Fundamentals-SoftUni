using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {

                if (input.Contains("|"))
                {
                    string[] data = input.Split(" | ");
                    string forceSide = data[0];
                    string forceUser = data[1];
                    if (forceUsers.ContainsKey(forceSide) == false)
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }
                    if (forceUsers.Any(x => x.Value.Contains(forceUser) == false))
                    {
                        forceUsers[forceSide].Add(forceUser);
                    }
                }
                if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ");
                    string forceUser = data[0];
                    string forceSide = data[1];

                    if (forceUsers.ContainsKey(forceSide) == false)
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }
                    if (forceUsers.Any(x => x.Value.Contains(forceUser)))
                    {
                        foreach (var item in forceUsers)
                        {
                            if (item.Value.Contains(forceUser))
                            {
                                item.Value.Remove(forceUser);
                            }
                        }
                    }
                    if (forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }

                }
            }
            foreach (var item in forceUsers.Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {

                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var element in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {element}");
                }

            }

        }
    }
}
