using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45 * people;
                        if (people >= 30)
                        {
                            price -= price * 0.15;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.80 * people;
                        if (people >= 30)
                        {
                            price -= price * 0.15;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46 * people;
                        if (people >= 30)
                        {
                            price -= price * 0.15;
                        }
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        if (people >= 100)
                        {
                            people -= 10;
                        }
                        price = 10.90 * people;
                    }
                    else if (day == "Saturday")
                    {
                        if (people >= 100)
                        {
                            people -= 10;
                        }
                        price = 15.60 * people;
                    }
                    else if (day == "Sunday")
                    {
                        if (people >=100)
                        {
                            people -= 10;
                        }
                        price = 16 * people;                   
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15 * people;
                        if (people >= 10&&people<=20)
                        {
                            price -= price * 0.15;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        price = 20 * people;
                        if (people >= 10 && people <= 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.5 * people;
                        if (people >= 10 && people <= 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
