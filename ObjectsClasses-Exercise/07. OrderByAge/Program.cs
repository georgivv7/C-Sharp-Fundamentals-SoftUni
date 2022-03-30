using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                Person person = new Person(input[0], input[1], int.Parse(input[2]));
                personList.Add(person);
            }
            var sorted = personList.OrderBy(x => x.Age).ToList();
            foreach (Person person in sorted)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
    }
}
