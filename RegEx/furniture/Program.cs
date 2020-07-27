using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine();
            var pattern = @"[>]{2}[A-Z]+[a-z]*[<]{2}\d+\.?\d*!\d+";
            var purchasedItems = new Dictionary<string, double>();
            var separator = new string [] { ">>", "<<", "!" };
            while (item != "Purchase")
            {
                bool haveMatch = Regex.IsMatch(item, pattern);
                if (haveMatch)
                {

                    var currentMatch = Regex.Match(item, pattern);
                    var splittedMatch = currentMatch
                        .ToString()
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    var itemName = splittedMatch[0];
                    var itemPrice = double.Parse(splittedMatch[1]);
                    var itemQuantity = long.Parse(splittedMatch[2]);
                    var itemTotalPrice = itemPrice * itemQuantity;
                    purchasedItems.Add(itemName, itemTotalPrice);

                }
                item = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (purchasedItems.Count > 0)
            {
                foreach (var element in purchasedItems)
                {
                    if (element.Key.Length > 0)
                    {
                        Console.WriteLine(element.Key);
                    }
                }
            }
            Console.WriteLine($"Total money spend: {purchasedItems.Sum(x=>x.Value):f2}");
        }
    }
}
