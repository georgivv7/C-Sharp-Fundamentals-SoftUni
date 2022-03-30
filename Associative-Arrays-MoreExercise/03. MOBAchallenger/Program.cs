using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBAchallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ");
                    string name = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (players.ContainsKey(name) == false)
                    {
                        players.Add(name, new Dictionary<string, int> { { position, skill } });
                    }
                    else if (players.ContainsKey(name))
                    {
                        if (players[name].ContainsKey(position))
                        {
                            if (players[name][position] < skill)
                            {
                                players[name][position] = skill;
                            }
                        }
                        else
                        {
                            players[name].Add(position, skill);
                        }

                    }
                }
                else
                {
                    string[] data = input.Split(" vs ");
                    string player1 = data[0];
                    string player2 = data[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        string playerToRemove = "";
                        foreach (var item in players[player1])
                        {
                            foreach (var elm in players[player2])
                            {
                                if (item.Key == elm.Key)
                                {
                                    if (players[player1].Values.Sum() > players[player2].Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                    else if (players[player1].Values.Sum() < players[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                            }
                        }
                        players.Remove(playerToRemove);
                    }
                }
            }
            foreach (var item in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                int skill = item.Value.Values.Sum();
                Console.WriteLine($"{item.Key}: {skill} skill");
                foreach (var elem in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {elem.Key} <::> {elem.Value}");
                }
            }
        }
    }
}
