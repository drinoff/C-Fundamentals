using System;
using System.Linq;

namespace friendlistMaintanance
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = Console.ReadLine().Split(", ").ToList();

            var input = Console.ReadLine();
            var blacklisted = 0;
            var lost = 0;

            while (input != "Report")
            {
                var command = input.Split().ToArray();
                var action = command[0];

                switch (action)
                {
                    case "Blacklist":
                        var name = command[1];
                        if (!friends.Contains(name))
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        else
                        {
                            var index = friends.IndexOf(name);
                            friends[index] = "Blacklisted";
                            blacklisted++;
                            Console.WriteLine($"{name} was blacklisted.");
                        }
                        break;
                    case "Error":
                        var index2 = int.Parse(command[1]);
                        if (friends[index2] != "Blacklisted" && friends[index2] != "Lost")
                        {
                            var keepUser = friends[index2];
                            friends[index2] = "Lost";
                            lost++;
                            Console.WriteLine($"{keepUser} was lost due to an error.");
                        }
                        break;
                    case "Change":
                        index2 = int.Parse(command[1]);
                        var newName = command[2];
                        if (index2 >= 0 && index2 <= friends.Count - 1)
                        {
                            var temp = friends[index2];
                            friends[index2] = newName;
                            Console.WriteLine($"{temp} changed his username to {newName}.");
                        }
                        break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
