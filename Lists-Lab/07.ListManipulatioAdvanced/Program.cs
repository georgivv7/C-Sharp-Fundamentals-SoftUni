using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulatioAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";
            int counterOfPrevious = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    if (counterOfPrevious > 0)
                    {
                        Console.WriteLine(String.Join(" ", nums));
                    }
                    break;
                }
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Add":
                        counterOfPrevious++;
                        int addNumber = int.Parse(commands[1]);
                        nums.Add(addNumber);
                        break;
                    case "Remove":
                        counterOfPrevious++;
                        int removeNumber = int.Parse(commands[1]);
                        nums.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        counterOfPrevious++;
                        int removeIndex = int.Parse(commands[1]);
                        nums.RemoveAt(removeIndex);
                        break;
                    case "Insert":
                        counterOfPrevious++;
                        int number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        nums.Insert(index, number);
                        break;
                    case "Contains":
                        int numberC = int.Parse(commands[1]);
                        if (nums.Contains(numberC))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evenPrint = new List<int>();

                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {
                                evenPrint.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evenPrint));
                        break;

                    case "PrintOdd":
                        List<int> oddPrint = new List<int>();
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                oddPrint.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", oddPrint));
                        break;
                    case "GetSum":
                        Console.WriteLine(nums.Sum());
                        break;
                    case "Filter":
                        var condition = commands[1];
                        int filter = int.Parse(commands[2]);
                        if (condition == "<")
                        {
                            List<int> result = nums.FindAll(i => i < filter);
                            Console.WriteLine(String.Join(" ", result));
                        }
                        else if (condition == ">")
                        {
                            List<int> result1 = nums.FindAll(i => i > filter);
                            Console.WriteLine(String.Join(" ", result1));

                        }
                        else if (condition == ">=")
                        {
                            List<int> result2 = nums.FindAll(i => i >= filter);
                            Console.WriteLine(String.Join(" ", result2));
                        }
                        else if (condition == "<=")
                        {
                            List<int> result3 = nums.FindAll(i => i <= filter);
                            Console.WriteLine(String.Join(" ", result3));
                        }
                        break;
                }
            }

        }
    }
}
