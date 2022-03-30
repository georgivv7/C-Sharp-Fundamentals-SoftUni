using System;
using System.Linq;

namespace _02._ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case"swap":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        int temp = array[index1];
                        array[index1] = array[index2];
                        array[index2] = temp;
                        break;
                    case "multiply":
                        index1 = int.Parse(command[1]);
                        index2 = int.Parse(command[2]);
                        int result = array[index1] * array[index2];
                        array[index1] = result;
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i]--;
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", ",array));
        }
    }
}
