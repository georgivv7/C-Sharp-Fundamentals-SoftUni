using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int result = CalculatedNumber(first, operators, second);
            Console.WriteLine(result);
        }
        static int CalculatedNumber(int first, char operators, int second) 
        {
            int result = 0;
            switch (operators)
            {             
                case'/':
                    result = first / second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
            }
            return result;
        }  
    }
}
