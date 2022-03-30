using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    wagons.Add(number);
                }
                else
                {
                    int num = int.Parse(command[0]);
                    if (num <= maxCapacity)
                    {

                        for (int i = 0; i < wagons.Count; i++)
                        {
                            int current = wagons[i];
                            current += num;
                            if (current <= maxCapacity)
                            {
                                wagons.Insert(i, current);
                                wagons.RemoveAt(i + 1);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
