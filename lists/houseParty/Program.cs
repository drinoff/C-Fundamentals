using System;
using System.Collections.Generic;
using System.Linq;

namespace houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCount = int.Parse(Console.ReadLine());
            var guestList = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command.Count == 3)
                {
                    if (guestList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(command[0]);
                    }
                }
                else
                {
                    if (guestList.Contains(command[0]))
                    {
                        guestList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
