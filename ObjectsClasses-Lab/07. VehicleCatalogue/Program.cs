using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();
            catalogueVehicle.Cars = new List<Car>();
            catalogueVehicle.Trucks = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('/');
                if (input[0] == "end")
                {
                    break;
                }
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int horseOrWeight = int.Parse(input[3]);
                if (type == "Car")
                {
                    catalogueVehicle.Cars.Add(new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horseOrWeight                      
                    });
                    

                }
                else if(type == "Truck")
                {

                    catalogueVehicle.Trucks.Add(new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horseOrWeight
                        
                    });                    
                }
                
            }
            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalogueVehicle.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalogueVehicle.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    class Truck
    {
        public string Brand;
        public string Model;
        public int Weight;
    }

    class Car
    {
        public string Brand;
        public string Model;
        public int HorsePower;
    }

     class CatalogueVehicle
    {
        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
