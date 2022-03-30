using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._CardGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (player1.Count == 0)
                {
                    break;
                }
                if (player2.Count == 0)
                {
                    break;
                }
                if (player1[0] > player2[0])
                {
                    player1.Add(player2[0]);
                    player1.Insert(player1.Count - 1, player1[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player2[0] > player1[0])
                {
                    player2.Add(player1[0]);
                    player2.Insert(player2.Count - 1, player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player1[0] == player2[0])
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }

            }
            if (player1.Count > 0)
            {
                int sum = player1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (player2.Count > 0)
            {
                int sum = player2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }



        }
    }
}
