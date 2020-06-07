using System;
using System.Collections.Generic;
using System.Linq;

namespace wizzardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenCards = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            var cardDeck = new List<string>();
            var command = Console.ReadLine();
            while (command != "Ready")
            {
                var splittedCommand = command.Split();
                var action = splittedCommand[0];
                switch (action)
                {
                    case "Add":
                        Add(givenCards,cardDeck, splittedCommand[1]);
                        break;
                    case "Insert":
                        Insert(givenCards, cardDeck, splittedCommand[1], int.Parse(splittedCommand[2]));
                        break;
                    case "Remove":
                        Remove(cardDeck, splittedCommand[1]);
                        break;
                    case "Swap":
                        Swap(cardDeck, splittedCommand[1], splittedCommand[2]);
                        break;
                    case "Shuffle":
                        Shuffle(cardDeck);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",cardDeck));
        }
        static List<string> Add(List<string> givenCards,List<string> cardDeck, string cardName)
        {

            if (!givenCards.Contains(cardName))
            {
                Console.WriteLine("Card not found.");
                return cardDeck;
            }
            else
            {
                
                cardDeck.Add(cardName);
                return cardDeck;
            }
        }
        static List<string> Insert(List<string> givenCards,List<string> cardDeck, string cardName, int index)
        {
            if (!givenCards.Contains(cardName))
            {
                Console.WriteLine("Error!");
                return cardDeck;
            }
            else
            {
                if (index < 0 || index > cardDeck.Count - 1)
                {
                    Console.WriteLine("Error!");
                    return cardDeck;
                }
                
                cardDeck.Insert(index, cardName);
                return cardDeck;
            }
        }
        static List<string> Remove(List<string> cardDeck, string cardName)
        {
            if (!cardDeck.Contains(cardName))
            {
                Console.WriteLine("Card not found.");
                return cardDeck;
            }
            cardDeck.Remove(cardName);
            return cardDeck;
        }
        static List<string> Swap(List<string> cardDeck, string cardName1, string cardName2)
        {
            var temp = string.Empty;
            var firstIndex = cardDeck.IndexOf(cardName1);
            var secondIndex = cardDeck.IndexOf(cardName2);
            temp = cardDeck[firstIndex];
            var temp2 = cardDeck[secondIndex];
            cardDeck.RemoveAt(firstIndex);
            cardDeck.Insert(firstIndex, temp2);
            cardDeck.RemoveAt(secondIndex);
            cardDeck.Insert(secondIndex, temp);
            return cardDeck;
        }
        static List<string> Shuffle(List<string> cardDeck)
        {
            cardDeck.Reverse();
            return cardDeck;
        }
    }
}
