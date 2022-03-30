using System;

namespace _05.PrintPartASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                
                char ascii = (char)i; 
                Console.Write($"{ascii} ");
            }

        }
    }
}
