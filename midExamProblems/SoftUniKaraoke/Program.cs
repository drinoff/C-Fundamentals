using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(", ").ToList();
            var songs = Console.ReadLine().Split(", ").ToList();

            var input = Console.ReadLine();
            var awards = new Dictionary<string, List<string>>();

            while (input!="dawn")
            {
                var performance = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var performer = performance[0];
                var song = performance[1];
                var award = performance[2];


            }
        }
    }
}
