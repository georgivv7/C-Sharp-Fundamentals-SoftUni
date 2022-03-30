using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double sumLightsabers = priceLightsaber * Math.Ceiling(students*1.1);
            double sumRobes = priceRobes * students;                  
            double sumBelts = (priceBelts * students)-(students/6*priceBelts);               
            double totalSum = sumBelts + sumLightsabers + sumRobes;
            if (totalSum<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                totalSum -= money;
                Console.WriteLine($"Ivan Cho will need {totalSum:F2}lv more.");
            }


        }
    }
}
