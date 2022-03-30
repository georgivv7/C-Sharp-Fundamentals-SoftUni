using System;

namespace _02._CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string word1 = words[0];
            string word2 = words[1];

            int result = CharSum(word1, word2);
            Console.WriteLine(result);
      }
        static int CharSum(string first, string second) 
        {
            int totalSum = 0;
            string longest = "";
            string shortest = "";

            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                totalSum += shortest[i] * longest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                totalSum += longest[i];
            }

            return totalSum;
        }
    }
}
