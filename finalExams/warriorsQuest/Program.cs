using System;
using System.Text.RegularExpressions;

namespace warriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var skill = Console.ReadLine();
            var input = Console.ReadLine();
            while (input != "For Azeroth")
            {
                var command = input.Split();
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
                        char letter = char.Parse(command[2]);


                        if (index >= 0 && index < skill.Length)
                        {
                            var skill2 = skill.ToCharArray();
                            skill2[index] = letter;
                            skill = string.Join("", skill2);
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Dispel too weak.");
                        }

                        break;
                    case "Target":
                        var subaction = command[1];
                        switch (subaction)
                        {
                            case "Change":
                                var subString = command[2];
                                var secondSubString = command[3];
                                skill = Regex.Replace(skill, subString, secondSubString);
                                Console.WriteLine(skill);
                                break;
                            case "Remove":
                                subString = command[2];
                                skill = Regex.Replace(skill, subString, "");
                                Console.WriteLine(skill);
                                break;
                            default:
                                Console.WriteLine("Command doesn't exist!");
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
