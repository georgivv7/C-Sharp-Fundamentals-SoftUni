using System;
using System.Linq;

namespace _01.EncryptSortPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string[] array = new string[n];
            int[] numbers = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
                string current = array[i];
                sum = 0;
                for (int k = 0; k < current.Length; k++)
                {
                    if (current[k] == 'a' || current[k] == 'e' || current[k] == 'i' || current[k] == 'o' || current[k] == 'u'
                        || current[k] == 'A' || current[k] == 'E' || current[k] == 'I' || current[k] == 'O' || current[k] == 'U')
                    {
                        sum += current[k] * current.Length;
                    }
                    else
                    {
                        sum += current[k] / current.Length;
                    }

                }
                numbers[i] = sum;
            }

            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }

    }
}

