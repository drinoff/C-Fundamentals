using System;
using System.Linq;

namespace easterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            var gifts = Console.ReadLine().Split().ToList();
            var input = Console.ReadLine();

            while (input != "No Money")
            {
                var command = input.Split().ToArray();
                var action = command[0];

                switch (action)
                {
                    case "OutOfStock":
                        var gift = command[1];
                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == gift)
                            {
                                gifts[i] = "None";
                            }
                        }                                               
                        break;
                    case "Required":
                        gift = command[1];
                        var index = int.Parse(command[2]);
                        if (index >= 0 && index < gifts.Count)
                        {
                            gifts[index] = gift;
                        }
                        break;
                    case "JustInCase":
                        gift = command[1];
                        gifts[gifts.Count - 1] = gift;
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",gifts.Where(x=>x!="None")));
        }
    }
}
