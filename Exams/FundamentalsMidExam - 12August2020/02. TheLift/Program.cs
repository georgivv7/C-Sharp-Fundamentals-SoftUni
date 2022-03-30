using System;
using System.Linq;

namespace _02._TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            var wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int currentSeatsInWagonTaken = 0;
            int peopleOn = 0;
            bool NoMorePoeople = false;
            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4)
                {
                    wagons[i]++;
                    currentSeatsInWagonTaken++;
                    if (peopleOn+currentSeatsInWagonTaken == peopleWaiting)
                    {
                        NoMorePoeople = true;
                        break;
                    }
                    
                }
                peopleOn += currentSeatsInWagonTaken;
                if (NoMorePoeople)
                {
                    break;
                }
                currentSeatsInWagonTaken = 0;
            }
            if (peopleWaiting < wagons.Length*4 && wagons.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagons));
            }
            else if (peopleWaiting > peopleOn)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting-peopleOn} people in a queue!");
                Console.WriteLine(String.Join(" ", wagons));
            }
            else if (wagons.All(x=>x == 4) && NoMorePoeople==true)
            {
                Console.WriteLine(String.Join(" ", wagons));
            }
        }       
    }
}

