using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                if(firstArray[i]==secondArray[i])
                {
                    int currentNums = firstArray[i];
                    sum1 += currentNums;
                }
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                int currentNums2 = secondArray[i];
                sum2 += currentNums2;
            }
            if (sum1==sum2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
            
        }
    }
}
