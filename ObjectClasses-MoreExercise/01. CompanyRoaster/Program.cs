using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CompanyRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                double salary = double.Parse(data[1]);
                string department = data[2];
                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Department = department
                };
                employees.Add(employee);
                if (departments.Contains(department) == false)
                {
                    departments.Add(department);
                }
            }
            string departmentHighest = string.Empty;
            double highestAverageSalary = double.MinValue;

            foreach (string department in departments)
            {
                double averageSalary = employees.Where(x => x.Department == department).Select(w => w.Salary).Average();
                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    departmentHighest = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentHighest}");

            foreach (var employee in employees.Where(x => x.Department == departmentHighest).OrderByDescending(w => w.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }
        }
    }

}
