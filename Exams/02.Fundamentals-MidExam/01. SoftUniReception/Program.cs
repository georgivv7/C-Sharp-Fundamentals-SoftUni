using System;

namespace _01._SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int worker1 = int.Parse(Console.ReadLine());
            int worker2 = int.Parse(Console.ReadLine());
            int worker3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            
            int time = 0;

            int studentsPerHour = worker1 + worker2 + worker3;

            while (studentsCount > 0)
            {
                time++;

                if (time % 4 == 0)
                {
                    continue;
                }

                studentsCount -= studentsPerHour;
            }

            Console.WriteLine($"Time needed: {time}h.");
            
            

            
        }
    }
}
