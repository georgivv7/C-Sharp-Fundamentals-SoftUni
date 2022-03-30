using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatedString(input, n);
        }

        static string RepeatedString(string newstring, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += newstring; 
                Console.Write($"{newstring}");               
            }
            return result;
            
        } 
    }
}
