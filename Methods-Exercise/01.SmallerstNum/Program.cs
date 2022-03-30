using System;

namespace _01.SmallerstNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintSmallestNum(num1, num2, num3);
        }
        static void PrintSmallestNum(int num1, int num2, int num3)
        {
            int smallestNum = Math.Min(Math.Min(num1, num2), num3);
            Console.WriteLine(smallestNum);
        }
    }
}
