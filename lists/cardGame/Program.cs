using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            var deckQueue = new Queue<int>(firstDeck);
            var deckQueue2 = new Queue<int>(secondDeck);
            
            while (true)
            {
                if (deckQueue.Count == 0)
                {
                    break;
                }
                if (deckQueue2.Count == 0)
                {
                    break;
                }
                var cardFirstDeck = deckQueue.Dequeue();
                var cardSecondDeck = deckQueue2.Dequeue();

                if (cardFirstDeck > cardSecondDeck)
                {
                    deckQueue.Enqueue(cardFirstDeck);
                    deckQueue.Enqueue(cardSecondDeck);
                }
                else if (cardSecondDeck > cardFirstDeck)
                {
                    deckQueue2.Enqueue(cardSecondDeck);
                    deckQueue2.Enqueue(cardFirstDeck);
                }
            }
            if (deckQueue.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {deckQueue2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deckQueue.Sum()}");
            }
        }
    }
}
