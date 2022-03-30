using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = Math.Abs(number);
            Console.WriteLine(MultiplyEvensByOddsDigits(n));
        }
        static int MultiplyEvensByOddsDigits(int n) 
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }
        static int GetSumOfEvenDigits(int n)
        {
            string number = n.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigits = int.Parse(number[i].ToString());
                if (currentDigits%2==0)
                {
                    sum += currentDigits;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            string number = n.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigits = int.Parse(number[i].ToString());
                if (currentDigits % 2 == 1)
                {
                    sum += currentDigits;
                }
            }
            return sum;
        }
    }
}
