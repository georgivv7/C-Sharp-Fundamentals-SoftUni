using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numersOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numersTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            numersTwo.Reverse();
            int num1 = 0;
            int num2 = 0;
            List<int> newList = new List<int>();
            for (int i = 0; i < numersOne.Count; i++)
            {
                if (numersOne.Count == 0 || numersTwo.Count==0)
                {
                    break;
                }
                newList.Add(numersOne[i]);
                newList.Add(numersTwo[i]);
                numersOne.Remove(numersOne[i]);
                numersTwo.Remove(numersTwo[i]);
                i = -1;
            }
            if (numersOne.Count > 0)
            {
                num1 = numersOne[0];
                num2 = numersOne[1];
            }
            else if (numersTwo.Count > 0)
            {
                num1 = numersTwo[0];
                num2 = numersTwo[1];
            }
            int bigger = Math.Max(num1, num2);
            int smaller = Math.Min(num1, num2);
            List<int> result = new List<int>();
            foreach (var number in newList)
            {
                if (number > smaller && number < bigger)
                {
                    result.Add(number);
                }
            }
            result.Sort();
            Console.WriteLine(String.Join(" ",result));

        }
    }
}
