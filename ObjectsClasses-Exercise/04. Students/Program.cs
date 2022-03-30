using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split().ToArray();
                Student student = new Student(data[0], data[1], double.Parse(data[2]));
                students.Add(student);          
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join(Environment.NewLine,students));
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
    
}
