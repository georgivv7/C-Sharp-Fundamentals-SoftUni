using System;
using System.Linq;

namespace _02._ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceries = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine())!= "Go Shopping!")
            {
                var input = command.Split();
                switch (input[0])
                {
                    case"Urgent":
                        string item = input[1];
                        if (groceries.Contains(item))
                        {
                            continue;
                        }
                        else
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        item = input[1];
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Correct":
                        string oldName = input[1];
                        string newName = input[2];
                        if (groceries.Contains(oldName))
                        {
                            int index = groceries.FindIndex(x => x == oldName);
                            groceries.RemoveAt(index);
                            groceries.Insert(index, newName);
                        }
                        break;
                    case "Rearrange":
                        item = input[1];
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }

            }
            Console.WriteLine(String.Join(", ",groceries));
        }
    }
}
