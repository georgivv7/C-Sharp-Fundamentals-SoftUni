using System;

namespace _01.MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distanceMeters = decimal.Parse(Console.ReadLine());
            decimal kilometers = distanceMeters / 1000;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
