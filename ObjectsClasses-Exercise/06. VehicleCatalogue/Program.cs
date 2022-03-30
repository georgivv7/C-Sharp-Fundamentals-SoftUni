using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<VehicleCatalogue> cars = new List<VehicleCatalogue>();
            List<VehicleCatalogue> trucks = new List<VehicleCatalogue>();
            double horsePowerCars = 0;
            double horsePowerTrucks = 0;
            string type = "";
            string aModel = "";
            string colour = "";
            double horsepower = 0;
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                 type = input[0];
                 aModel = input[1];
                 colour = input[2];
                 horsepower = double.Parse(input[3]);
                VehicleCatalogue vehicle = new VehicleCatalogue(type, aModel, colour , horsepower);
                if (input[0] == "car")
                {
                    horsePowerCars += double.Parse(input[3]);
                    cars.Add(vehicle);

                }
                else if (input[0] == "truck")
                {
                    horsePowerTrucks += double.Parse(input[3]);
                    trucks.Add(vehicle);
                }
            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {                  
                    break;
                }
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model.Contains(model))
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {cars[i].Model}");
                        Console.WriteLine($"Color: {cars[i].Colour}");
                        Console.WriteLine($"Horsepower: {cars[i].HorsePower}");
                    }
                }
                for (int i = 0; i < trucks.Count; i++)
                {
                    if (trucks[i].Model.Contains(model))
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {trucks[i].Model}");
                        Console.WriteLine($"Color: {trucks[i].Colour}");
                        Console.WriteLine($"Horsepower: {trucks[i].HorsePower}");
                    }
                }
            }

            double resultCars = horsePowerCars / cars.Count;
            double resultTrucks = horsePowerTrucks / trucks.Count;
            if (cars.Count > 0 )
            {
                Console.WriteLine($"Cars have average horsepower of: {resultCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {resultTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
            
        }
    }
    public class VehicleCatalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double HorsePower { get; set; }

        public VehicleCatalogue(string type, string model, string colour, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Colour = colour;
            this.HorsePower = horsePower;
        }
    }
}
