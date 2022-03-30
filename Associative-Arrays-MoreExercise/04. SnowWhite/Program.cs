using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] data = input.Split(" <:> ");
                string name = data[0];
                string hatColor = data[1];
                int physics = int.Parse(data[2]);

                if (dwarfs.ContainsKey(hatColor) == false)
                {
                    dwarfs.Add(hatColor, new Dictionary<string, int> { { name, physics } });
                }
                if (dwarfs.ContainsKey(hatColor))
                {
                    if (dwarfs[hatColor].ContainsKey(name) == false)
                    {
                        dwarfs[hatColor].Add(name, physics);
                    }

                }
                if (dwarfs.ContainsKey(hatColor) && dwarfs[hatColor].ContainsKey(name))
                {
                    if (dwarfs[hatColor][name] < physics)
                    {
                        dwarfs[hatColor][name] = physics;
                    }
                }
            }
            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var item in hatColor.Value)
                {
                    string name = item.Key;
                    int physics = item.Value;
                    sortedDwarfs.Add($"({hatColor.Key}) {name} <-> ", physics);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }

        }
    }
}
