using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int[]>> dragonType = new Dictionary<string, Dictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                string type = data[0];
                string name = data[1];
                if (data[2] == "null")
                {
                    data[2] = "45";
                }
                if (data[3] == "null")
                {
                    data[3] = "250";
                }
                if (data[4] == "null")
                {
                    data[4] = "10";
                }
                int damage = int.Parse(data[2]);
                int health = int.Parse(data[3]);
                int armor = int.Parse(data[4]);

                if (dragonType.ContainsKey(type) && dragonType[type].ContainsKey(name))
                {
                    dragonType[type][name][0] = damage;
                    dragonType[type][name][1] = health;
                    dragonType[type][name][2] = armor;
                }
                if (dragonType.ContainsKey(type) == false)
                {
                    dragonType.Add(type, new Dictionary<string, int[]>());
                    dragonType[type].Add(name, new int[3] { damage, health, armor });
                }
                if (dragonType.ContainsKey(type) && dragonType[type].ContainsKey(name) == false)
                {
                    dragonType[type].Add(name, new int[3] { damage, health, armor });
                }
            }


            foreach (var type in dragonType)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;
                int count = 0;

                foreach (var item in type.Value)
                {
                    averageDamage += item.Value[0];                  
                    averageHealth += item.Value[1];
                    averageArmor += item.Value[2];
                    count++;
                }
                Console.WriteLine($"{type.Key}::({averageDamage / count:f2}/{averageHealth / count:f2}" +
                    $"/{averageArmor / count:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

    }
}