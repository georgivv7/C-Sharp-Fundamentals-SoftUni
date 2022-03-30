using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < text.Count; i++)
            {
                char previous = text[i - 1];
                char current = text[i];
                if (previous == current)
                {
                    text.RemoveAt(i);
                    i--;
                }

            }
            Console.WriteLine(string.Join("",text));
           
        }
    }
}
