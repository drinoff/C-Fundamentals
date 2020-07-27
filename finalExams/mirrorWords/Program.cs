using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace mirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(@|#)(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            var pairs = Regex.Matches(input, pattern);
            var mirrorWords = new List<string>();
            if (pairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");
                for (int i = 0; i < pairs.Count; i++)
                {
                    var wordTwo = pairs[i].Groups["wordTwo"].Value;
                    var currentWordOne = pairs[i].Groups["wordOne"].Value;
                    var currentWordTwo = pairs[i].Groups["wordTwo"].Value.ToCharArray().Reverse();
                    var secondWord = string.Join("", currentWordTwo);
                    if (currentWordOne == secondWord)
                    {
                        currentWordOne += " <=> " + wordTwo;
                        mirrorWords.Add(currentWordOne);
                    }
                }
            }
            if(mirrorWords.Count==0)
            {
            Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",mirrorWords));
            }
        }
    }
}
