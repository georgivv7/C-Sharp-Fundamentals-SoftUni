using System;
using System.Globalization;

namespace _01._RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = random.Next(words.Length);
                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;

            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
