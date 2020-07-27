using System;
using System.Linq;

namespace tanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            var tanks = Console.ReadLine().Split(", ").ToList();

            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var input = Console.ReadLine().Split(", ").ToArray();
                var command = input[0];

                switch (command)
                {
                    case "Add":
                        var tankName = input[1];
                        if (!tanks.Contains(tankName))
                        {
                            tanks.Add(tankName);
                            Console.WriteLine("Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        break;
                    case "Remove":
                        tankName = input[1];
                        if (!tanks.Contains(tankName))
                        {
                            Console.WriteLine("Tank not found");
                        }
                        else
                        {
                            tanks.Remove(tankName);
                            Console.WriteLine("Tank successfully sold");
                        }
                        break;
                    case "Remove At":
                        var index = int.Parse(input[1]);
                        if (index < 0 || index > tanks.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            tanks.RemoveAt(index);
                            Console.WriteLine("Tank successfully sold");
                        }
                        break;
                    case "Insert":
                        index = int.Parse(input[1]);
                        tankName = input[2];
                        if (index < 0 || index > tanks.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            if (!tanks.Contains(tankName))
                            {
                                tanks.Insert(index, tankName);
                                Console.WriteLine("Tank successfully bought");
                            }
                            else
                            {
                                Console.WriteLine("Tank is already bought");
                            }
                        }
                        break;
                }

            }
            Console.WriteLine(string.Join(", ",tanks));
        }
    }
}
