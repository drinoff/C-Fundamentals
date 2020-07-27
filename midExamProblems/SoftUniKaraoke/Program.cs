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

            while (input != "dawn")
            {
                var performance = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var performer = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participants.Contains(performer))
                {
                    if (songs.Contains(song))
                    {
                        if (awards.ContainsKey(performer))
                        {
                            if (!awards[performer].Contains(award))
                            {
                                awards[performer].Add(award);
                            }
                        }
                        else
                        {
                            awards.Add(performer, new List<string> { award });
                        }
                    }
                }
                input = Console.ReadLine();
            }
            if (awards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");

                    var awardList = item.Value;

                    foreach (var award in awardList.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");

                    }
                }
            }
        }
    }
}
