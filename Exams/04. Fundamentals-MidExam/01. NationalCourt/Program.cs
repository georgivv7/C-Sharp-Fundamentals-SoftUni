using System;

namespace _01._NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());
            int time = 0;
            int clientsPerHour = employee1 + employee2 + employee3;
            while (totalPeople > 0)
            {
                time++;
                if (time % 4 == 0)
                {
                    continue;
                }
                totalPeople -= clientsPerHour;

            }
            Console.WriteLine($"Time needed: {time}h.");

        }
    }
}
