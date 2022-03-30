using System;

namespace _06._BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int IsClosed = 0;
            int IsOpened = 0;
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                if (current == "(")
                {
                    IsOpened++;
                }
                else if (current == ")")
                {
                    IsClosed++;
                    if (IsOpened - IsClosed != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (IsOpened == IsClosed)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
