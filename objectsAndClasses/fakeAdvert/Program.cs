using System;
using System.Collections.Generic;

namespace fakeAdvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>
                {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>
                {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
          

            List<string> fakeAdd = new List<string>();

            
            int randomNum = rand.Next(1, 6);
            fakeAdd.Add(phrases[randomNum]);

            randomNum = rand.Next(1, 6);
            fakeAdd.Add(events[randomNum]);

            
            randomNum = rand.Next(1, 8);
            fakeAdd.Add(authors[randomNum]);

            randomNum = rand.Next(1, 5);
            fakeAdd.Add(cities[randomNum]);

            
            
            Console.Write($"{fakeAdd[0]} {fakeAdd[1]} {fakeAdd[2]} – {fakeAdd[3]}");

            


        }
    }
}
