using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());          
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            double percent = (double)pokePower * 0.50;
            int targets = 0;
            while (pokePower>=distance)
            {
                pokePower -= distance;
                targets++;
                if (pokePower==percent&&exhaustion>0)
                {
                    pokePower /= exhaustion;
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}
