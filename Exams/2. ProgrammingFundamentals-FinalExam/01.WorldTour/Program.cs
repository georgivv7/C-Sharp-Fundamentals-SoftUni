using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                var data = input.Split(":");
                string command = data[0];
                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(data[1]);
                        string newDestination = data[2];
                        if (index >= 0 && index <= destinations.Length)
                        {
                            destinations = destinations.Insert(index, newDestination);
                        }
                        Console.WriteLine(destinations);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(data[1]);
                        int endIndex = int.Parse(data[2]);
                        if (startIndex >= 0 && startIndex <= destinations.Length-1 &&
                            endIndex >= 0 && endIndex <= destinations.Length-1 &&
                            startIndex <= endIndex)
                        {
                            destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(destinations);
                        break;
                    case "Switch":
                        string oldString = data[1];
                        string newString = data[2];
                        if (destinations.Contains(oldString)&& oldString!= newString)
                        {
                            destinations = destinations.Replace(oldString, newString);
                        }
                        Console.WriteLine(destinations);
                        break;
                }
                
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
