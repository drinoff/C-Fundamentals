using System;
using System.Linq;

namespace easterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = Console.ReadLine().Split().ToList();
            var commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                var action = command[0];

                switch (action)
                {
                    case "Include":
                        var shop = command[1];
                        shops.Add(shop);
                        break;
                    case "Visit":
                        var position = command[1];
                        var range = int.Parse(command[2]);
                        if (range <= shops.Count)
                        {
                            switch (position)
                            {
                                case "first":
                                    shops.RemoveRange(0, range);
                                    break;
                                case "last":
                                    shops.RemoveRange(shops.Count - range, range);
                                    break;
                            }
                        }
                        break;
                    case "Prefer":
                        var index1 = int.Parse(command[1]);
                        var index2 = int.Parse(command[2]);
                        if (index1 >= 0 && index1 < shops.Count && index2 >= 0 && index2 < shops.Count)
                        {
                            var temp = shops[index1];
                            shops[index1] = shops[index2];
                            shops[index2] = temp;
                        }
                        break;
                    case "Place":
                        shop = command[1];
                        var index = int.Parse(command[2]);
                        if (index + 1 > 0 && index + 1 < shops.Count)
                        {
                            shops.Insert(index + 1, shop);
                        }
                        break;
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ",shops));
        }
    }
}
