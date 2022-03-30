using System;
using System.Linq;

namespace _03._MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "End")
            {
                var command = input.Split();
                int index = int.Parse(command[1]);
                switch (command[0])
                {
                    case"Shoot":                       
                        int power = int.Parse(command[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= power;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        power = int.Parse(command[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, power);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        power = int.Parse(command[2]);
                        int startIndex = index - power;
                        int endIndex = power + index;
                        if (startIndex >= 0 && power < targets[targets.Count-1])
                        {                           
                            targets.RemoveRange(startIndex, power*2+1);                          
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join("|",targets));

        }
    }
}
