using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = Factorial1(num1) / Factorial2(num2);
            Console.WriteLine($"{result:F2}");
        }
        static double Factorial1(int num1)
        {
            double factorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static double Factorial2(int num2)
        {
            double factorial = 1;
            for (int i = 1; i <= num2; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


    }
}
