using System;

namespace _02.NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[numbers.Length - 1 - i]} ");
            }
        }
    }
}
