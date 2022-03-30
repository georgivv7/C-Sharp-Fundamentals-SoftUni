using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(command[1]);
                        list.Add(numberAdd);
                        break;
                    case "Remove":
                        int numberIndex = int.Parse(command[1]);
                        if (numberIndex < list.Count && numberIndex >= 0)
                        {
                            list.RemoveAt(numberIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Insert":
                        int number = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index < list.Count&& index>=0)
                        {
                            list.Insert(index, number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        int first = 0;
                        int last = 0;
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                first = list[0];
                                list.Add(first);
                                list.RemoveAt(0);

                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                last = list[list.Count - 1];
                                list.Insert(0, last);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
