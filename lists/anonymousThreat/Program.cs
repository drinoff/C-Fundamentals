using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine();
            while (command != "3:1")
            {
                var action = command.Split().ToArray();
                var startIndex = int.Parse(action[1]);
                var endIndex = int.Parse(action[2]);
                switch (action[0])
                {   
                    case "merge":
                        if (startIndex < 0 && endIndex < 0)
                        {
                            command = Console.ReadLine();
                            continue;
                        }
                        else if (startIndex > input.Count - 1 && endIndex > input.Count - 1)
                        {
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {

                            Merge(input, int.Parse(action[1]), int.Parse(action[2]));
                        }
                        break;
                    case "divide":
                        int partitions = int.Parse(action[2]);
                        int index = int.Parse(action[1]);
                        if (partitions <= input[index].Length && partitions >= 0)
                        {
                            Divide(input, int.Parse(action[1]), int.Parse(action[2]));
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
           
            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count - 1;
            }
           
            var inputAsString = string.Join("", input
                .Skip(startIndex)
                .Take(endIndex + 1 - startIndex));
            
            
                input.RemoveRange(startIndex, endIndex - startIndex);
                input[startIndex] = inputAsString;
            
            return input;
        }
        static List<string> Divide(List<string> input, int index, int partitions)
        {
            var substring = input[index];
            string newString = string.Empty;
            int leftOver = substring.Length % partitions + substring.Length / partitions;
            input.RemoveAt(index);
            for (int j = 0; j < substring.Length; j += substring.Length / partitions)
            {
                if (substring.Length - j == leftOver)
                {
                    newString += substring.Substring(j, leftOver);
                    break;
                }
                else
                {
                    newString += substring.Substring(j, substring.Length / partitions);
                    newString += " ";
                }
            }
            var newString2 = newString.Split().ToArray();

            if (index > input.Count - 1)
            {
                input.Add(newString);
            }
            else
            {
                input.InsertRange(index,newString2);
            }
            return input;
        }
    }
}
