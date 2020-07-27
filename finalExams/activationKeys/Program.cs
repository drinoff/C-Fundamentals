using System;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace activationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            var initKey = Console.ReadLine();
            var input = Console.ReadLine();
            while (input != "Generate")
            {
                var command = input.Split(">>>");
                var action = command[0];
                switch (action)
                {
                    case "Contains":
                        var substring = command[1];
                        if (initKey.Contains(substring))
                        {
                            Console.WriteLine($"{initKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        var upperOrLower = command[1];
                        var startIndex = int.Parse(command[2]);
                        var endIndex = int.Parse(command[3]);
                        if (upperOrLower == "Lower")
                        {
                           var subString = initKey.Substring(startIndex, endIndex - startIndex);
                            initKey = Regex.Replace(initKey, subString, subString.ToLower());
                        }
                        else
                        {
                            var subString = initKey.Substring(startIndex, endIndex - startIndex);
                            initKey = Regex.Replace(initKey, subString, subString.ToUpper());
                        }
                        Console.WriteLine(initKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);
                        initKey = initKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(initKey);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {initKey}");
        }
    }
}
