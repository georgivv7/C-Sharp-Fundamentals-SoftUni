using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxList = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split();
                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                decimal price = itemPrice * itemQuantity;

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Name = itemName,
                    Price = itemPrice,
                    ItemQuantity = itemQuantity,
                    PriceForBox = price

                };
                boxList.Add(box);
                input = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxList.OrderBy(boxes => boxes.PriceForBox).ToList();
            sortedBoxes.Reverse();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Name} - ${box.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }


        }
    }

    public class Box
    {

        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }

    }
}
