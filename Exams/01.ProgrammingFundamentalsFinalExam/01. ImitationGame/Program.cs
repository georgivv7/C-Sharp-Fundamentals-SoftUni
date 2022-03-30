using System;
using System.Text;
using System.Linq;

namespace _01._ImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "Decode")
            {
                var command = input.Split('|');
                string operation = command[0];
                if (operation == "Move")
                {
                    int n = int.Parse(command[1]);
                    string substring = encrypted.Substring(0, n);
                    encrypted = encrypted.Remove(0,n);
                    encrypted = encrypted.Insert(encrypted.Length, substring);
                }
                if (operation == "ChangeAll")
                {
                    char replace = char.Parse(command[1]);
                    char replacement = char.Parse(command[2]);
                    encrypted = encrypted.Replace(replace, replacement);
                    
                }
                if (operation == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string addChar = command[2];
                    encrypted = encrypted.Insert(index, addChar);
                }
            }
            Console.WriteLine($"The decrypted message is: {encrypted}");
        }
    }
}
