using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < (numbers.Count - 1) / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    leftTime *= 0.8;
                }
                leftTime += numbers[i];

            }
            for (int i = numbers.Count - 1; i > (numbers.Count - 1) / 2; i--)
            {
                if (numbers[i] == 0)
                {
                    rightTime *= 0.8;
                }
                rightTime += numbers[i];
            }
            string left = "left";
            string right = "right";
            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is {left} with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is {right} with total time: {rightTime}");
            }
        }
    }
}
