using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int quantity = 0;
            string material = string.Empty;
            while (keyMaterials["shards"] < 250 || keyMaterials["fragments"] < 250 || keyMaterials["motes"] < 250)
            {
                string[] data = input.Split(" ");
                for (int i = 0; i < data.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(data[i]);
                    }
                    if (i % 2 != 0)
                    {
                        material = data[i].ToLower();
                        if (keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] += quantity;
                            if (keyMaterials[material] >= 250)
                            {
                                break;
                            }
                        }
                        else if (junk.ContainsKey(material) == false)
                        {
                            junk.Add(material, quantity);
                        }
                        else if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                    }
                }
                if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (keyMaterials["shards"] >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                keyMaterials["shards"] -= 250;
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                keyMaterials["fragments"] -= 250;
            }
            else if (keyMaterials["motes"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                keyMaterials["motes"] -= 250;
            }


            var sortedkeyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(w => w.Key);
            foreach (var item in sortedkeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            var sortedJunk = junk.OrderBy(x => x.Key);
            foreach (var item in sortedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
