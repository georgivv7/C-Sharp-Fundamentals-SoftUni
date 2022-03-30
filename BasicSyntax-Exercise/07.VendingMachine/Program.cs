using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;
            double price = 0;
            while (true)
            {
                double coins = double.Parse(input);
                if (coins!=0.1&&coins!=0.2&&coins!=0.5&&coins!=1&&coins!=2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    totalMoney -= coins;
                }
                totalMoney += coins;
                input =Console.ReadLine();
                if (input == "Start")
                {
                    break;                  
                }               
            }
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: {totalMoney:f2}");
                    break;
                }
                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                }

                if (totalMoney >= price)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if(price>totalMoney)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

        }
    }
}
