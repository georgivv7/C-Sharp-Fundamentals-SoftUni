using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> examResults = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] data = input.Split('-');
                string name = data[0];
                string language = data[1];
                if (data[1] == "banned")
                {
                    if (examResults.ContainsKey(name))
                    {
                        examResults.Remove(name);
                        continue;
                    }

                }
                int points = int.Parse(data[2]);


                if (examResults.ContainsKey(name) == false)
                {
                    examResults.Add(name, points);
                }
                else
                {
                    if (examResults[name] < points)
                    {
                        examResults[name] = points;
                    }

                }
                if (submissions.ContainsKey(language) == false)
                {
                    submissions.Add(language, 1);
                }
                else
                {
                    submissions[language]++;
                }

            }
            Console.WriteLine("Results:");
            foreach (var result in examResults.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
