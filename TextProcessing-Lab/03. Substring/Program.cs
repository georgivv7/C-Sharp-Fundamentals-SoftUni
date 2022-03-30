using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();  
            string word1 = Console.ReadLine();

            int startIndex = word1.IndexOf(word);
            while (startIndex!=-1)
            {
                word1 = word1.Remove(startIndex, word.Length);
                startIndex = word1.IndexOf(word);
            }
            Console.WriteLine(word1);
        }
    }
}
