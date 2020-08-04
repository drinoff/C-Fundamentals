using System;

namespace stringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "Done")
            {
                var command = input.Split();
                var action = command[0];

                switch (action)
                {
                    case "Change":
                        var charToReplace = command[1];
                        var replacement = command[2];
                        line = line.Replace(charToReplace, replacement);
                        Console.WriteLine(line);
                        break;
                    case "Includes":
                        var stringToCheck = command[1];
                        if (line.Contains(stringToCheck))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":
                        stringToCheck = command[1];
                        var stringLen = stringToCheck.Length;
                        var lineEnd = line.Substring(line.Length - stringToCheck.Length, stringToCheck.Length);
                        if (lineEnd == stringToCheck)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        line = line.ToUpper();
                        Console.WriteLine(line);
                        break;
                    case "FindIndex":
                        var charIndexToFind = command[1];
                        var index = line.IndexOf(charIndexToFind);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        var startIndex = int.Parse(command[1]);
                        var length = int.Parse(command[2]);
                        var notRemoved = line.Substring(startIndex, length);
                        Console.WriteLine(notRemoved);
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
