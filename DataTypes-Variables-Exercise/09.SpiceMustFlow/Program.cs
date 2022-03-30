using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int starting = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;
            
            while (starting>=100)
            {
                days++;
                totalAmount += (starting - 26);
                starting -= 10;
                if (starting<100)
                {
                    totalAmount -= 26;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
