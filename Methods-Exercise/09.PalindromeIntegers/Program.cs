using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IfPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IfPalindrome(string input)
        {
            var reversed = input.Reverse().ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (!(input[i] == reversed[i]))
                {
                    return false;
                }
            }   
            
            return true;
            
        }
    }
}
