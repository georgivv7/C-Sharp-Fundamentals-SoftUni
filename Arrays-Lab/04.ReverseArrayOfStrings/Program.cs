using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string items = Console.ReadLine();
            string[] array = items.Split(' ').ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                _ = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[array.Length-1-i]} ");
            }
        }
    }
}
