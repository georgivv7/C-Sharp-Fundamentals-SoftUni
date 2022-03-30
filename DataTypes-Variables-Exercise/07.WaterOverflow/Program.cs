using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int currentLitres = 0;
            for (int i = 1; i <=n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                currentLitres += litres;
                if (currentLitres>capacity)
                {                  
                    Console.WriteLine("Insufficient capacity!");
                    currentLitres -= litres;
                }
            }
            Console.WriteLine(currentLitres);
        }
    }
}
