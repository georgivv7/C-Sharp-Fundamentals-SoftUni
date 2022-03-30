using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiply = int.Parse(Console.ReadLine());
            if (multiply>10)
            {
                Console.WriteLine($"{number} X {multiply} = {number*multiply}");
            }
            else
            {
                for (int i = multiply; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            
        }
    }
}
