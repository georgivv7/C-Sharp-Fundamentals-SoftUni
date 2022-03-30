using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "Craft!")
            {
                var commands = input.Split(" - ");
                string command = commands[0];
                string item = commands[1];
                switch (command)
                {
                    case"Collect":
                        if (!items.Contains(item))
                        {
                            items.Add(item);
                        }
                        break;
                    case "Drop":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                        }
                        break;
                    case "Combine Items":
                       var elements = item.Split(':');
                        string oldItem = elements[0];
                        string newItem = elements[1];
                        if (items.Exists(x=>x == oldItem))
                        {
                            int index = items.FindIndex(x => x == oldItem);
                            index += 1;
                            items.Insert(index, newItem);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",items));
        }
    }
}
