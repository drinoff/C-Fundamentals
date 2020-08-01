using System;
using System.Collections.Generic;
using System.Linq;

namespace concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bandMembers = new Dictionary<string, List<string>>();
            var bandTime = new Dictionary<string, int>();
            var separator = new string[] { "; ", ", " };

            while (input != "start of concert")
            {
                var command = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];
                switch (action)
                {
                    case "Add":
                        var bandName = command[1];
                        if (!bandMembers.ContainsKey(bandName))
                        {
                            bandMembers.Add(bandName, new List<string>());
                            bandTime.Add(bandName, 0);
                            for (int i = 2; i < command.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(command[i]))
                                {
                                    bandMembers[bandName].Add(command[i]);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 2; i < command.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(command[i]))
                                {
                                    bandMembers[bandName].Add(command[i]);
                                }
                            }
                        }
                        break;
                    case "Play":
                        bandName = command[1];
                        var time = int.Parse(command[2]);
                        if (!bandTime.ContainsKey(bandName))
                        {
                            bandTime.Add(bandName, time);
                            bandMembers.Add(bandName, new List<string>());
                        }
                        else
                            bandTime[bandName] += time;
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total time: {bandTime.Sum(x=>x.Value)}");
            foreach (var band in bandTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> { band.Value}");
            }
            var bandNameInput = Console.ReadLine();
            Console.WriteLine(bandNameInput);
            foreach (var item in bandMembers[bandNameInput])
            {
                Console.WriteLine($"=> {item}");
            }
        }
    }
}
