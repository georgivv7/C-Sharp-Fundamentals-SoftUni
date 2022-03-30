using System;
using System.Linq;

namespace _02._ShootForWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int shootTarget = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index > targets.Length - 1 || index < 0)
                {
                    continue;
                }

                if (targets[index] == -1)
                {
                    continue;
                }
                else
                {
                    shootTarget = targets[index];
                    for (int i = 0; i <= targets.Length-1; i++)
                    {
                        if (targets[i] == -1 || targets[index] == -1)
                        {
                            continue;
                        }
                        
                        if (targets[i] > shootTarget)
                        {
                            targets[i] -= shootTarget;
                        }
                        else if (targets[i] <= shootTarget)
                        {
                            targets[i] += shootTarget;
                        }
                        
                    }
                    targets[index] = -1;
                    count++;
                }

            }
            Console.Write($"Shot targets: {count} -> ");
            foreach (var item in targets)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
