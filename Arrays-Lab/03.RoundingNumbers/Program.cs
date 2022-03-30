using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubleVariables = Console.ReadLine();
            double[] numbers = doubleVariables.Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
               int roundedNums = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNums}");
            }
        }
    }
}
