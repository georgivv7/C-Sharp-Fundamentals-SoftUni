using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            double totalPrice = 0;
            while (input != "buy")
            {
                string[] data = input.Split();
                string productName = data[0];
                double price = double.Parse(data[1]);
                int quantity = int.Parse(data[2]);
                totalPrice = quantity * price;
                if (products.ContainsKey(productName)==false)
                {                   
                    products.Add(productName, new List<double>() { price,quantity});
                }
                else if (products.ContainsKey(productName))
                {
                    products[productName][0] = price;
                    products[productName][1] += quantity;               
                }

                input = Console.ReadLine();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0]*product.Value[1]):f2}");
            }
        }
    }
}
