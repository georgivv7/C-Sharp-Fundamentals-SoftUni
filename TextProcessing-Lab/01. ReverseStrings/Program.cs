using System;
using System.Text;

namespace _01._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            while ((input = Console.ReadLine())!= "end")
            {
                StringBuilder reveresed = new StringBuilder();
                for (int i = input.Length-1; i >= 0; i--)
                {
                    reveresed.Append(input[i]); 
                }
                Console.WriteLine($"{input} = {reveresed}");
            }
        }
    }
}
