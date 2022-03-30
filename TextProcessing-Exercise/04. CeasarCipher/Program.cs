using System;
using System.Text;

namespace _04._CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedWord = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int result = 3 + text[i];
                char symbol = (char)result;
                encryptedWord.Append(symbol);
            }

            string encrypted = encryptedWord.ToString();
            Console.WriteLine(encrypted);
        }
    }
}
