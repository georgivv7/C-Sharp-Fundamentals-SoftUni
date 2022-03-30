using System;
using System.Linq;

namespace _03._HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var houses = Console.ReadLine().Split("@",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = string.Empty;
            int lastPositionIndex = 0;
            int housesCount = houses.Count;
            while ((input = Console.ReadLine())!= "Love!")
            {
                var command = input.Split();
                int indexHouse = int.Parse(command[1]);
                indexHouse += lastPositionIndex;
                if (indexHouse >= houses.Count)
                {
                    indexHouse = 0;
                }
                if (houses[indexHouse] == 0)
                {
                    Console.WriteLine($"Place {indexHouse} already had Valentine's day.");
                }
                else
                {
                    houses[indexHouse] -= 2;
                    if (houses[indexHouse] == 0)
                    {
                        Console.WriteLine($"Place {indexHouse} has Valentine's day.");
                    }
                }

                lastPositionIndex = indexHouse;

            }

            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");
            
            foreach (var house in houses)
            {
                if (house == 0)
                {
                    housesCount--;
                }
            }
            if (housesCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {housesCount} places.");
            }
        }
    }
}
