using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while ((input=Console.ReadLine())!= "end")
            {
                string[] data = input.Split(" : ");
                string course = data[0];
                string student = data[1];

                if (courses.ContainsKey(course)==false)
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                else if (courses.ContainsKey(course))
                {
                    courses[course].Add(student);
                }

            }           
            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                int registeredStudents = course.Value.Count;
                Console.WriteLine($"{course.Key}: {registeredStudents}");
                foreach (var name in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {name}");
                }
                
            }
        }
    }
}
