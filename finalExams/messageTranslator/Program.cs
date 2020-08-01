using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace messageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < msgCount; i++)
            {
                var input = Console.ReadLine();
                var pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<msg>[A-Za-z]{8,})\]";
                var hasMatch = Regex.IsMatch(input, pattern);
                
                if(!hasMatch)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    var msgMatch = Regex.Match(input, pattern);
                    var msg = msgMatch.Groups["msg"].Value;
                    var numbers = new List<int>();
                    for (int j = 0; j < msg.Length; j++)
                    {
                        numbers.Add((int)msg[j]);
                    }
                    Console.WriteLine($"{msgMatch.Groups["command"].Value}: {string.Join(" ",numbers)}");
                }
            }
        }
    }
}
