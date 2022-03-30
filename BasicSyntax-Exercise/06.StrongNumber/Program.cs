using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int sum = 0;
            int factoriel = 1;
            while (num>0)
            {
                int number = num % 10;
                num /= 10;
                factoriel = 1;

                for (int i =1; i <= number; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }
            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
