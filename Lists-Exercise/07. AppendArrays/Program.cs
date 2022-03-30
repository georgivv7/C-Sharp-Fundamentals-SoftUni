using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfArrays = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> numbers = new List<int>();
            foreach (var item in listOfArrays)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
