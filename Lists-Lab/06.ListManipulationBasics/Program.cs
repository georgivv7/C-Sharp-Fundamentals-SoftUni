using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(String.Join(" ", nums));
                    break;
                }
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int addNumber = int.Parse(tokens[1]);
                        nums.Add(addNumber);
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(tokens[1]);
                        nums.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        int removeIndex = int.Parse(tokens[1]);
                        nums.RemoveAt(removeIndex);
                        break;
                    case "Insert":
                        int number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);   
                        nums.Insert(index, number);
                        break;
                }
            }
        }
    }
}
