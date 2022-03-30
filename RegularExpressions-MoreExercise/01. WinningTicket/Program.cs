using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] {' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            string patternLeft = @"([$@#^]{6,10})";
            string patternRight = @"([$@#^]{6,10})";

            foreach (var item in tickets)
            {
                if (item.Length == 20)
                {
                    string left = new string(item.Take(10).ToArray());
                    string right = new string(item.Skip(10).ToArray());
                    Match matchLeft = Regex.Match(left, patternLeft);
                    Match matchRight = Regex.Match(right, patternRight);
                    if (matchLeft.Success && matchRight.Success)
                    {
                        if (matchLeft.Length >= 6 && matchLeft.Length <= 9)
                        {
                            if (matchRight.Length == matchLeft.Length)
                            {
                                Console.WriteLine($"ticket \"{item}\" - {matchLeft.Length}{matchLeft.Value[0]}");
                            }
                            
                        }
                        else if (matchLeft.Length == 10 && matchRight.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{item}\" - {matchLeft.Length}{matchLeft.Value[0]} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{item}\" - no match");
                    }

                }              
                else
                {
                    Console.WriteLine("invalid ticket");
                }


            }
        }
    }
}
