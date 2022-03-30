using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeInWords(grade);
        }
        static void GradeInWords(double grades) 
        {
            if (grades>=2.00&&grades<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            if (grades >= 3.50 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            if (grades >= 4.50 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            if (grades >= 5.50 && grades <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
