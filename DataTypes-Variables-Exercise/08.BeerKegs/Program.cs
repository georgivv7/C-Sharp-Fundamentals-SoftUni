using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float biggestKeg = 0;
            string biggest = "";
            for (int i = 1; i <=n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)Math.PI * radius * radius * height;
                if (volume>biggestKeg)
                {
                    biggestKeg = volume;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
            

        }
    }
}
