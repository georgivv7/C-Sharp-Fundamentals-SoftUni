using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int hitPoints = int.Parse(data[1]);
                int manaPoints = int.Parse(data[2]);

                if (heroes.ContainsKey(name) == false)
                {
                    heroes.Add(name, new int[2]);
                    heroes[name][0] = hitPoints;
                    heroes[name][1] = manaPoints;
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string heroName = tokens[1];
                switch (command)
                {
                    case "Heal":
                        int amount = int.Parse(tokens[2]);
                        int current = heroes[heroName][0];
                        heroes[heroName][0] += amount;
                        if (heroes[heroName][0] > 100)
                        {
                            heroes[heroName][0] = 100;
                            Console.WriteLine($"{heroName} healed for {100 - current} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {amount} HP!");
                        }
                        break;
                    case "Recharge":
                        amount = int.Parse(tokens[2]);
                        current = heroes[heroName][1];
                        heroes[heroName][1] += amount;
                        if (heroes[heroName][1] > 200)
                        {
                            heroes[heroName][1] = 200;
                            Console.WriteLine($"{heroName} recharged for {200 - current} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(tokens[2]);
                        string attacker = tokens[3];
                        heroes[heroName][0] -= damage;
                        if (heroes[heroName][0] > 0)
                        {
                            int currentHP = heroes[heroName][0];
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currentHP} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroes.Remove(heroName);
                        }
                        break;
                    case "CastSpell":
                        int manaNeeded = int.Parse(tokens[2]);
                        string spell = tokens[3];
                        if (heroes[heroName][1] >= manaNeeded)
                        {
                            heroes[heroName][1] -= manaNeeded;
                            int currentMana = heroes[heroName][1];
                            Console.WriteLine($"{heroName} has successfully cast {spell} and now has {currentMana} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                        }
                        break;
                }
            }

            foreach (var item in heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                string name = item.Key;
                int hitPower = item.Value[0];
                int manaPower = item.Value[1];
                Console.WriteLine($"{name}");
                Console.WriteLine($"  HP: {hitPower}");
                Console.WriteLine($"  MP: {manaPower}");
            }

        }
    }
}
