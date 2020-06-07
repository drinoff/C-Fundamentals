using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var command = Console.ReadLine();
            while (command != "Done")
            {
                var splittedCommand = command.Split().ToArray();
                var action = splittedCommand[0];

                switch (action)
                {
                    case "Move":
                        if (splittedCommand[1] == "Left")
                        {
                            MoveLeft(parts, int.Parse(splittedCommand[2]));
                        }
                        else
                        {
                            MoveRight(parts, int.Parse(splittedCommand[2]));
                        }
                        break;
                    case "Check":
                        if (splittedCommand[1] == "Even")
                        {
                            var evenString = EvenPos(parts);
                            Console.WriteLine(string.Join(" ",evenString));
                        }
                        else
                        {
                            var oddString = OddPos(parts);
                            Console.WriteLine(string.Join(" ",oddString));
                        }
                        break;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"You crafted {string.Join("",parts)}!");
        }
        static string[] MoveLeft(string[] parts, int index)
        {
            if (index < 0 || index > parts.Length-1)
            {
                return parts;
            }
            else
            {
                if (index - 1 < 0)
                {
                    return parts;
                }
                else
                {
                    var temp = "";
                    temp = parts[index - 1];
                    parts[index - 1] = parts[index];
                    parts[index] = temp;
                    return parts;
                }
            }
        }
        static string[] MoveRight(string[] parts, int index)
        {
            if (index < 0 || index > parts.Length-1)
            {
                return parts;
            }
            else
            {
                if (index + 1 > parts.Length - 1)
                {
                    return parts;
                }
                else
                {
                    var temp = "";
                    temp = parts[index + 1];
                    parts[index + 1] = parts[index];
                    parts[index] = temp;
                    return parts;
                }
            }
        }
        static string EvenPos(string[] parts)
        {
            var evenString = string.Empty;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenString += parts[i];
                    evenString += " ";
                }

            }
            return evenString;
        }
        static string OddPos(string[] parts)
        {
            var oddString = string.Empty;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddString += parts[i];
                    oddString += " ";
                }

            }
            return oddString;
        }
    }
}
