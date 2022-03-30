using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> result = new Dictionary<string, string>();
            int startIndexType = 0;
            int lastIndexType = 0;
            int startIndexCoordinates = 0;
            int lastIndexCoordinates = 0;
            string metal = string.Empty;
            string coordinates = string.Empty;
            while ((input = Console.ReadLine()) != "find")
            {
                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int current = input[i] - data[counter];
                    counter++;
                    if (counter >= data.Length)
                    {
                        counter = 0;
                    }
                    sb.Append((char)current);
                }

                startIndexType = sb.ToString().IndexOf('&');
                lastIndexType = sb.ToString().LastIndexOf('&');
                startIndexCoordinates = sb.ToString().IndexOf('<');
                lastIndexCoordinates = sb.ToString().IndexOf('>');

                metal = sb.ToString().Substring(startIndexType + 1,
                    lastIndexType - startIndexType - 1);
                coordinates = sb.ToString().Substring(startIndexCoordinates + 1,
                    lastIndexCoordinates - startIndexCoordinates - 1);
                result.Add(metal, coordinates);
                sb.Clear();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"Found {item.Key} at {item.Value}");
            }
        }
    }
}
