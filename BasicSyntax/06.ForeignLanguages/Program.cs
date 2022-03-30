using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "";

            if (country=="USA"||country=="England")
            {
                language = "English";
            }
            else if (country=="Spain"||country=="Mexico"||country=="Argentina")
            {
                language = "Spanish";
            }
            else
            {
                Console.WriteLine("unknown");
            }
            Console.WriteLine(language);
        }
    }
}
