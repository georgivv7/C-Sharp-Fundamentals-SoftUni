using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (cars.ContainsKey(car) == false)
                {
                    cars.Add(car, new int[2]);
                    cars[car][0] = mileage;
                    cars[car][1] = fuel;
                }
            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] data = command.Split(" : ");
                string commands = data[0];
                string car = data[1];

                switch (commands)
                {
                    case "Drive":
                        int distance = int.Parse(data[2]);
                        int fuel = int.Parse(data[3]);
                        if (fuel > cars[car][1])
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car][0] += distance;
                            cars[car][1] -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (cars[car][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }
                        break;
                    case "Refuel":
                        fuel = int.Parse(data[2]);
                        int current = cars[car][1];
                        cars[car][1] += fuel;
                        if (cars[car][1] > 75)
                        {
                            cars[car][1] = 75;
                            Console.WriteLine($"{car} refueled with {75 - current} liters");
                        }
                        else
                        {
                            Console.WriteLine($"{car} refueled with {fuel} liters");
                        }
                        break;
                    case "Revert":
                        int kilometers = int.Parse(data[2]);
                        cars[car][0] -= kilometers;
                        if (cars[car][0] >= 10000)
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        else
                        {
                            cars[car][0] = 10000;
                        }
                        break;
                }
            }
            foreach (var item in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                string car = item.Key;
                int mileage = item.Value[0];
                int fuel = item.Value[1];
                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
