using System;

namespace _08._LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];
                char beforeLetter = text[0];
                char afterLetter = text[text.Length - 1];
                decimal number = decimal.Parse(text.Substring(1, text.Length - 2));

                int letterBeforePostition = char.Parse(beforeLetter.ToString().ToUpper()) - 64;
                int letterAfterPostition = char.Parse(afterLetter.ToString().ToUpper()) - 64;

                if (beforeLetter >= 65 && beforeLetter <= 90)
                {
                    number /= letterBeforePostition;
                }
                else
                {
                    number *= letterBeforePostition;
                }
                if (afterLetter >= 65 && afterLetter <= 90)
                {
                    number -= letterAfterPostition;
                }
                else
                {
                    number += letterAfterPostition;
                }
                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
