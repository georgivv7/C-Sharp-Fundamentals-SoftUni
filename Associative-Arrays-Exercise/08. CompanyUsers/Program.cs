using System;
using System.Collections.Generic;
using System.Linq;


namespace _08._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine())!= "End")
            {
                string[] data = input.Split(" -> ");
                string name = data[0];
                string id = data[1];

                if (employees.ContainsKey(name)==false)
                {
                    employees.Add(name, new List<string>());
                    employees[name].Add(id);
                }
                else if (employees.ContainsKey(name))
                {
                    if (employees[name].Contains(id))
                    {
                        continue;
                    }
                    employees[name].Add(id);
                }
            }

            foreach (var employee in employees.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{employee.Key}");
                foreach (var id in employee.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
                
            }

        }
    }
}
