using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            int numOfMoves = 0;
            var input = Console.ReadLine().Split().ToArray();

            while (true)
            {
                if (input[0] == "end")
                {
                    break;
                }
                numOfMoves++;
                int index1 = int.Parse(input[0]);
                int index2 = int.Parse(input[1]);
                if (index1 < 0 || index1>list.Count-1 || index2 < 0 || index2 > list.Count-1 || index1 == index2)
                {
                    string element = $"-{numOfMoves}a";
                    list.Insert(list.Count / 2, element);
                    list.Insert(list.Count / 2, element);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (list[index1] == list[index2])
                {
                    string element = list[index1];
                    Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");
                    list.RemoveAll(x => x == element);
                }
                else if (list[index1] != list[index2])
                {
                    Console.WriteLine("Try again!");                   
                }
                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {numOfMoves} turns!");
                    break;
                }

                input = Console.ReadLine().Split().ToArray();
            }
            if (input[0] == "end" && list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }
                
            }
        }
    }
}
