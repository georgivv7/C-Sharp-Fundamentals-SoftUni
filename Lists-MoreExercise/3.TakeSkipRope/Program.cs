using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var numbers = new List<int>();
            var nonNumbers = new List<char>();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    int num = int.Parse(text[i].ToString());
                    numbers.Add(num);
                }
                else
                {
                    nonNumbers.Add(text[i]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            string result = null;

            int indexForSkip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                result += new string(nonNumbers.Skip(indexForSkip).Take(takeList[i]).ToArray());
                indexForSkip += skipList[i] + takeList[i];
            }
            Console.WriteLine(result);
        }
    }
}
