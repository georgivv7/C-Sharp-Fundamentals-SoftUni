using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsCount(input);
        }

        static void VowelsCount(string text)
        {
            int vowelCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a'|| text[i] == 'e'|| text[i] == 'o'|| text[i] == 'u'||
                    text[i] == 'y'||text[i] == 'i')
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine(vowelCounter);
        }
    }
}
