using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);       
        }
        static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentDigit = i;
                bool oddDigit = false;
                while (currentDigit != 0)
                {
                    sum += currentDigit % 10;
                    if ((!(currentDigit % 2 == 0)))
                    {
                        oddDigit = true;
                    }
                    currentDigit /= 10;
                }
                if (sum % 8 == 0 && oddDigit==true)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
