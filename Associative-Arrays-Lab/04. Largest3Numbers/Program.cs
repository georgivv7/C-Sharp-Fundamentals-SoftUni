using System;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sorted = nums.OrderByDescending(x => x).ToArray();

            if (sorted.Length < 3)
            {
                Console.WriteLine(string.Join(" ",sorted));
            }
            else
            {
                var three = sorted.Take(3).ToArray();
                Console.WriteLine(String.Join(" ",three));
            }
        }
    }
}
