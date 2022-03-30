using System;
using System.Collections.Generic;

namespace _05._SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> carNumbers = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string command = data[0];
                string name = data[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = data[2];
                        if (carNumbers.ContainsKey(name) == false)
                        {
                            carNumbers.Add(name, licensePlateNumber);
                            Console.WriteLine($"{name} registered { licensePlateNumber} successfully");
                        }
                        else if (carNumbers.ContainsValue(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (carNumbers.ContainsKey(name) == false)
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else if (carNumbers.ContainsKey(name))
                        {
                            string plate = carNumbers[name];
                            Console.WriteLine($"{name} unregistered successfully");
                            carNumbers.Remove(name, out plate);
                        }
                        break;
                }
            }
            foreach (var number in carNumbers)
            {
                Console.WriteLine($"{number.Key} => {number.Value}");
            }
        }
    }
}
