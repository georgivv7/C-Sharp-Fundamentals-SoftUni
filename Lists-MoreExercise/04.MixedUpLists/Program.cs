using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet

{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> originalQuality = new List<int>(drumSet);
            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int powerApplied = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= powerApplied;

                    if (drumSet[i] <= 0)
                    {
                        double price = originalQuality[i] * 3;
                        if (savings > price)
                        {
                            savings -= price;
                            drumSet[i] = originalQuality[i];

                        }
                    }
                }
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        drumSet.Remove(drumSet[i]);
                        originalQuality.Remove(originalQuality[i]);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
