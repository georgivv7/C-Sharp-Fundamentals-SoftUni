using System;
using System.Collections.Generic;

namespace _02._OldestFamilyMember
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> family = new Dictionary<string, int>();
            string oldestMember = string.Empty;
            int oldestMemberAge = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);

                if (family.ContainsKey(name)==false)
                {
                    family.Add(name, age);
                }
                
            }
            foreach (var member in family)
            {
                if (member.Value > oldestMemberAge)
                {
                    oldestMember = member.Key;
                    oldestMemberAge = member.Value;
                }
            }
            Console.WriteLine($"{oldestMember} {oldestMemberAge}");
        }
    }
}
