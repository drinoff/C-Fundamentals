using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace warrQuaest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input = Console.ReadLine();
            
            while (input != "For Azeroth")
            {
                var command = input.Split().ToArray();

                var action = command[0];
                
                switch (action)
                {
                    case "GladiatorStance":
                        skill = skill.ToUpper();
                        Console.WriteLine(skill);
                        break;
                    case "DefensiveStance":
                        skill = skill.ToLower();
                        Console.WriteLine(skill);
                        break;
                    case "Dispel":
                        var index = int.Parse(command[1]);
                        if (index > skill.Length)
                        {
                            Console.WriteLine("Dispel too weak.");
                        }
                        else
                        {
                            skill = skill.IndexOf();
                            skill = skill.Remove(index + 1);
                            Console.WriteLine("Success!");
                        }
                        break;
                    case "Target":
                        switch (command[1])
                        {
                            case "Change":
                                skill.Replace(command[2], command[3]);
                                Console.WriteLine(skill);
                                break;
                            case "Remove":
                                skill.Replace(command[2], "");
                                Console.WriteLine(skill);
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
