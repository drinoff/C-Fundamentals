using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            var destinations = Console.ReadLine();
            var pattern = @"(=|\/)(?<dest>[A-Z]{1}[A-z]{2,})\1";
            var validDest = Regex.Matches(destinations, pattern);
            var destList = new List<string>();
            for (int i = 0; i < validDest.Count; i++)
            {
                destList.Add(validDest[i].Groups["dest"].Value);
            }
            var sum = 0;
            for (int i = 0; i < destList.Count; i++)
            {
                sum += destList[i].Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",destList)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
