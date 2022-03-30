using System;

namespace _01._ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double priceWithoutTax = 0;
            while (true)
            {
                if (command == "special" || command == "regular")
                {
                    break;
                }

                double currentPrice = double.Parse(command);
                if (currentPrice < 0 )
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTax += currentPrice;
                }
                
                command = Console.ReadLine();
            }
            double taxes = priceWithoutTax * 0.20;
            double total = priceWithoutTax + taxes;
            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (command == "special")
            {
                total -= total * 0.10;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
        }
    }
}
