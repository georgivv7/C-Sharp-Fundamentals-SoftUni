using System;

namespace _01._AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AdsMessage ads = new AdsMessage();
                Console.WriteLine(ads.MessageRandomizer());
            }

        }

        public class AdsMessage
        {
            public string[] Phrases = new string[] { "Excellent product.","Such a great product.", "I always use that product.",
             "Best product of its category.","Exceptional product.","I can’t live without this product."};
            public string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            public string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            public string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public string MessageRandomizer()
            {
                Random rand = new Random();
                string currentPhrase = Phrases[rand.Next(0, Phrases.Length)];
                string currentEvent = Events[rand.Next(0, Events.Length)];
                string currentAuthor = Authors[rand.Next(0, Authors.Length)];
                string currentCity = Cities[rand.Next(0, Cities.Length)];

                return $"{currentPhrase} {currentEvent} {currentAuthor} – {currentCity}";
            }
        }
    }
}
        