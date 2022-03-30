using System;

namespace _03.GamingStone
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = string.Empty;
            double price = 0;
            double spent = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input=="Game Time")
                {
                    Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
                    break;
                }
                if (input!= "OutFall 4"&&input!= "CS: OG"&&input!= "Zplinter Zell"&&input!= "Honored 2"&&input!= "RoverWatch"&&input!= "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                }
                if (price>balance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    balance -= price;
                    spent += price;
                    Console.WriteLine($"Bought {input}");
                }
                if (balance<=0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }               
            }
        }
    }
}
