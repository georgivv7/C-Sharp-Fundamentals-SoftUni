using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().ToList();
            int power = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                char current = list[i];
                if (current == '>')
                {
                    power += int.Parse(list[i + 1].ToString());
                    sb.Append(current);
                }
                else if (power == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);

        }
    }
}
