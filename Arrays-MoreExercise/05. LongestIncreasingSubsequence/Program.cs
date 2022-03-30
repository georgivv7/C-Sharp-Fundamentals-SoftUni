using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lengths = new int[numbers.Length];
            int[] previous = new int[numbers.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                lengths[i] = 1;
                previous[i] = -1;
                for (int j = 0; j <= i-1; j++)
                {
                    if (numbers[j]<numbers[i] && lengths[j]+1>lengths[i])
                    {
                        lengths[i] = 1 + lengths[j];
                        previous[i] = j;
                    }
                }
                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            while (lastIndex!=-1)
            {
                longestSeq.Add(lengths[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestSeq.Reverse();
            Console.WriteLine(String.Join(" ",longestSeq));
        }
    }
}
