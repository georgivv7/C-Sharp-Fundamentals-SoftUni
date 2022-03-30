using System;

namespace _01._CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonBattle = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattle} won battles and {energy} energy");
                    return;
                }

                energy -= distance;
                wonBattle++;
                if (wonBattle % 3 == 0)
                {
                    energy += wonBattle;
                }
            }

            Console.WriteLine($"Won battles: {wonBattle}. Energy left: {energy}");
        }
    }
}
