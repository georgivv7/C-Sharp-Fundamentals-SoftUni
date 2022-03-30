using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] data = rooms[i].Split();
                string command = data[0];
                int amount = int.Parse(data[1]);
                if (command == "potion")
                {

                    if (health + amount > 100)
                    {
                        amount = 100 - health;
                    }

                    health += amount;

                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {amount} bitcoins.");
                    bitcoins += amount;
                }
                else
                {
                    string monster = command;
                    health -= amount;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {                    
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
