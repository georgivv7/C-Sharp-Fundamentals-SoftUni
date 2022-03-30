using System;
using System.Linq;
using System.Numerics;

namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long sum = 0;
                if (input[0] >= input[1])
                {
                    long currentDigit = input[0];
                    while (currentDigit != 0)
                    {
                        sum += currentDigit % 10;
                        currentDigit /= 10;
                    }
                }
                else if (input[0] < input[1])
                {
                    long currentDigit = input[1];
                    while (currentDigit != 0)
                    {
                        sum += currentDigit % 10;
                        currentDigit /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
