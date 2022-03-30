using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split();
            int bomb = int.Parse(input[0]);
            int power = int.Parse(input[1]);
            int index = nums.IndexOf(bomb);


            while (index != -1)
            {
                int detonationLeft = index - power;
                int detonationRight = index + power;
                if (detonationLeft < 0)
                {
                    detonationLeft = 0;
                }
                if (detonationRight > nums.Count - 1)
                {
                    detonationRight = nums.Count - 1;
                }
                nums.RemoveRange(detonationLeft, detonationRight - detonationLeft + 1);
                index = nums.IndexOf(bomb);
            }

            int sum = nums.Sum();
            Console.WriteLine(sum);

        }
    }
}
