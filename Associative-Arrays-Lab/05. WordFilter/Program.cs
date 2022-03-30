using System;
using System.Linq;

namespace _05._WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine().Split().Where(x=>x.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine,fruits));
            
        }
    }
}
