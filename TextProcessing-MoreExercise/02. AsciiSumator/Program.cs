using System;

namespace _02._AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > character1 && text[i] < character2)
                {
                    sum += text[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
