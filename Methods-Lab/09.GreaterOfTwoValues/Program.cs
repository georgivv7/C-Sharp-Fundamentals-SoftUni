using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(IsBigger(a, b));
            }
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(IsBigger(a, b));
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(IsBigger(a, b));
            }

        }
        static string IsBigger(string a, string b)
        {
            int compare = a.CompareTo(b);
            if (compare>0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int IsBigger(int a, int b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char IsBigger(char a, char b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


    }
}
