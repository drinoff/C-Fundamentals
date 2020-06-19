using System;
using System.Collections.Generic;
using System.Linq;

namespace helloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            var separatedItems = Console.ReadLine().Split(new string[] { "->", "|" }, StringSplitOptions.RemoveEmptyEntries);
            var budget = double.Parse(Console.ReadLine());

            var boughtItemsPrices = new List<double>();

            for (int i = 1; i < separatedItems.Length; i+=2)
            {
                var currentItemPrice = double.Parse(separatedItems[i]);
                if (separatedItems[i - 1] == "Clothes")
                {
                    if (currentItemPrice <= 50)
                    {
                        if (budget >= currentItemPrice)
                        {
                            budget -= currentItemPrice;
                            boughtItemsPrices.Add(currentItemPrice);
                        }
                    }
                }
                else if (separatedItems[i - 1] == "Shoes")
                {
                    if (currentItemPrice <= 35)
                    {
                        if (budget >= currentItemPrice)
                        {
                            budget -= currentItemPrice;
                            boughtItemsPrices.Add(currentItemPrice);
                        }
                    }
                }
                else
                {
                    if (currentItemPrice <= 20.50)
                    {
                        if (budget >= currentItemPrice)
                        {
                            budget -= currentItemPrice;
                            boughtItemsPrices.Add(currentItemPrice);
                        }
                    }
                }               
            }
            var profit = boughtItemsPrices.Sum() * 0.4;
            for (int i = 0; i < boughtItemsPrices.Count; i++)
            {
                boughtItemsPrices[i] = boughtItemsPrices[i] * 1.4;
            }
            var newBudget = boughtItemsPrices.Sum() + budget;

            foreach (var item in boughtItemsPrices)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");

            if (newBudget > 150)
            {                
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
