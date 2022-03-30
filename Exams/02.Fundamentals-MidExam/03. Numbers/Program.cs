using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = 0;
            for (int i = 0; i < list.Count; i++)
            {
                average += list[i];
            }
            average /= list.Count;
            List<int> greaterThanAverage = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    greaterThanAverage.Add(list[i]);
                }
            }
            var top5 = new List<int>();
            if (greaterThanAverage.Count > 0)
            {
                if (greaterThanAverage.Count > 5)
                {
                    top5 = greaterThanAverage.OrderByDescending(x => x).Take(5).ToList();
                }
                else if(greaterThanAverage.Count <= 5)
                {
                    top5 = greaterThanAverage.OrderByDescending(x => x).ToList();
                }
                              
                Console.WriteLine(String.Join(" ", top5));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
