using System;


namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAdvertisements = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product."
                    , "Best product of its category.", "Exceptional product."
                    , "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles.I am happy of the results!"
                    , "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied."
                    , "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random words = new Random();

            for (int i = 0; i < countOfAdvertisements; i++)
            {
                string phrase = phrases[words.Next(0, phrases.Length - 1)];
                string eventss = events[words.Next(0, events.Length - 1)];
                string authorss = authors[words.Next(0, authors.Length - 1)];
                string city = cities[words.Next(0, cities.Length - 1)];

                Console.WriteLine($"{phrase} {eventss} {authorss} - {city}");
            }
        }
    }
}
