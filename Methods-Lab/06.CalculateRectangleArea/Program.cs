using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaRectangle(width, height));
        }
        static int AreaRectangle(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}
