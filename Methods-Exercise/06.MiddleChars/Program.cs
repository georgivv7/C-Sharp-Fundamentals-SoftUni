using System;

namespace _06.MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }
        static void PrintMiddleChar(string text)
        {
            char middleChar = text[text.Length / 2];
            if (text.Length%2==0)
            {
                char extraChar = text[(text.Length / 2) - 1];
                Console.Write($"{extraChar}{middleChar}");
                return;
            }
            Console.WriteLine(middleChar);
        }
    }
}
