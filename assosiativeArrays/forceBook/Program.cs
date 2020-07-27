using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceUsers = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    var splittedInput = input.Split(" | ");
                    var user = splittedInput[1];
                    var side = splittedInput[0];
                    if (forceUsers.ContainsKey(side))
                    {

                        if (!forceUsers[side].Contains(user))
                        {
                            forceUsers[side].Add(user);
                        }
                    }
                    else
                    {
                        forceUsers.Add(side, new List<string> { user });
                    }
                }
                else
                {
                    var hasFound = false;
                    var splittedInput = input.Split(" -> ");
                    var user = splittedInput[0];
                    var side = splittedInput[1];
                    foreach (var item in forceUsers)
                    {
                        if (item.Value.Contains(user))
                        {
                            item.Value.Remove(user);
                            forceUsers[side].Add(user);
                            hasFound = true;
                            break;
                        }
                    }
                    if (!hasFound)
                    {
                        forceUsers.Add(side, new List<string> { user });
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                input = Console.ReadLine();
            }
            foreach (var item in forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value).Where(x => x.Value.Count != 0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: { item.Value.Count}");
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"!{element}");
                }
            }
        }
    }
}
