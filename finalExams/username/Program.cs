using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace username
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "Sign up")
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "Case":
                        var lowerOrUpper = command[1];
                        if (lowerOrUpper == "lower")
                        {
                            username = username.ToLower();
                            Console.WriteLine(username);
                        }
                        else
                        {
                            username = username.ToUpper();
                            Console.WriteLine(username);
                        }
                        break;
                    case "Reverse":
                        var startIndex = int.Parse(command[1]);
                        var endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < username.Length && endIndex >= 0 && endIndex < username.Length)
                        {
                            var subString = username.Substring(startIndex, (endIndex - startIndex) + 1);
                            var result = subString.Reverse();
                            var reversedResult = string.Join("", result);
                            Console.WriteLine(reversedResult);
                        }
                        break;
                    case "Cut":
                       var subStringforCutting = command[1];
                        if(!username.Contains(subStringforCutting))
                        {
                            Console.WriteLine($"The word {username} doesn't contain {subStringforCutting}.");
                        }
                        else
                        {
                            startIndex = username.IndexOf(subStringforCutting);
                            var length = subStringforCutting.Length;
                            username = username.Remove(startIndex, length);
                            Console.WriteLine(username);
                        }
                        break;
                    case "Replace":
                        var charToReplace = command[1];
                        username = username.Replace(charToReplace, "*");
                        Console.WriteLine(username);
                        break;
                    case "Check":
                        var charToCheck = command[1];
                        if(username.Contains(charToCheck))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {charToCheck}.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
