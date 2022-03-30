using System;

namespace _02.EnglishNameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;
            string digit = lastDigit.ToString();
            switch (digit)
            {
                case "0":
                    digit = "zero";
                    break;
                case"1":
                    digit = "one";
                    break;
                case "2":
                    digit = "two";
                    break;
                case "3":
                    digit = "three";
                    break;
                case "4":
                    digit = "four";
                    break;
                case "5":
                    digit = "five";
                    break;
                case "6":
                    digit = "six";
                    break;
                case "7":
                    digit = "seven";
                    break;
                case "8":
                    digit = "eight";
                    break;
                case "9":
                    digit = "nine";
                    break;
            }
            Console.WriteLine(digit);
        }
    }
}
