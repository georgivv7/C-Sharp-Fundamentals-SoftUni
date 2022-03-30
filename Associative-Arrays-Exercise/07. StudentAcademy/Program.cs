using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> students = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                int count = 1;
                if (students.ContainsKey(student)==false)
                {
                    students.Add(student, grade);
                }
                else
                {
                    count++;
                    students[student] += grade;
                    students[student] /= count;                   
                }
            }
            var sorted = students.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value);
            foreach (var student in sorted)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
