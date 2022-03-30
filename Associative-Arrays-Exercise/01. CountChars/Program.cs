using System;
using System.Collections.Generic;

namespace _01._CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (dictionary.ContainsKey(word[j]))
                    {
                        dictionary[word[j]]++;
                    }
                    else
                    {
                        dictionary.Add(word[j], 1);
                    }
                     
                }
            }
            foreach (var symbol in dictionary)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
