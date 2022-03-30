using System;

namespace _01._BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double maxBonusPoints = 0;
            double maxAttendances = 0;
            for (int i = 0; i < countStudents; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                totalBonus = attendances / countLectures * (5 + initialBonus);
                if (totalBonus >= maxBonusPoints)
                {
                    maxBonusPoints = totalBonus;
                    maxAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonusPoints)}.");
            Console.WriteLine($"The student has attended {Math.Round(maxAttendances)} lectures.");
        }
    }
}
