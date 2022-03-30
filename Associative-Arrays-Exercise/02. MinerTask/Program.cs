using System;
using System.Collections.Generic;

namespace _02._MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            List<string> list = new List<string>();

            while ((input = Console.ReadLine()) != "stop")
            {
                list.Add(input);              
            }

            for (int i = 0; i < list.Count; i++)
            {
                
                if (i%2==0 && resources.ContainsKey(list[i])==false) 
                {
                    resources.Add(list[i], new int());
                }

                else if (i % 2 != 0 && resources.ContainsKey(list[i-1]))
                {
                    string resource = list[i-1];
                    int quantity = int.Parse(list[i]);
                    resources[resource] += quantity;
                }

            }
            foreach ( var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
           

        }
    }
}
