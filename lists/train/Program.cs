using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            while (input != "end")
            {
                var command = input.Split().ToArray();
                if (command.Contains("Add"))
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity - wagons[i] >= int.Parse(command[0]))
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
