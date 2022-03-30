using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (product)
            {
                case"coffee":
                    Console.WriteLine($"{Coffee(quantity):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{Water(quantity):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{Coke(quantity):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{Snacks(quantity):f2}");
                    break;
            }

        }
        static double Water(double quantity)
        {
            double result = quantity * 1.00;
            return result;
        }
        static double Coffee(double quantity)
        {
            double result = quantity * 1.50;
            return result;
        }
        static double Coke(double quantity)
        {
            double result = quantity * 1.40;
            return result;
        }
        static double Snacks(double quantity)
        {
            double result = quantity * 2.00;
            return result;
        }
    }
}
