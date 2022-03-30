using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            int num = 0;
            int current = 0;
            int index = 0;
            string message = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                num = numbers[i];
                index = 0;
                while (num > 0)
                {
                    current = num % 10;
                    index += current;
                    num /= 10;
                    if (index > text.Length)
                    {
                        index -= text.Length;
                    }
                }
                char currentChar = text[index];
                message += currentChar;
                text = text.Remove(index,1);

            }

            Console.WriteLine(message);

        }
    }
}
