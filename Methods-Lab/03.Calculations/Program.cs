using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (input)
            {
                case"add":
                    Console.WriteLine(Add(num1, num2));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(num1, num2));
                    break;
                case "subtract":
                    Console.WriteLine(Substract(num1, num2));
                    break;
                case "divide":
                    Console.WriteLine(Divide(num1, num2));
                    break;
            }
        }
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        static int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
