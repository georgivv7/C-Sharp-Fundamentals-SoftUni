using System;
using System.Numerics;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger[] result = TribonacciSequence(num);
            Console.WriteLine(String.Join(" ", result));
        }
        static BigInteger[] TribonacciSequence(int num)
        {
            BigInteger[] tribonacci = new BigInteger[num];
            switch (num)
            {
                case 1:
                    tribonacci[0] = 1;
                    break;
                case 2:
                    tribonacci[0] = 1;
                    tribonacci[1] = 1;
                    break;
                case 3:
                    tribonacci[0] = 1;
                    tribonacci[1] = 1;
                    tribonacci[2] = 2;
                    break;
                default:
                    tribonacci[0] = 1;
                    tribonacci[1] = 1;
                    tribonacci[2] = 2;
                    for (int i = 3; i < num; i++)
                    {
                        tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                    }
                    break;
            }          
            return tribonacci;
        }
    }
}
