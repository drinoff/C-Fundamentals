using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace emojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var emojiPattern = @"(\*\*|::)[A-Z][a-z]{2,}\1";
            var digitsPattern = @"(?<number>\d)";
            var emojies = Regex.Matches(text, emojiPattern).ToList();
            var digits = Regex.Matches(text, digitsPattern).ToList();
            long coolnesFactor = 1;
            var finalEmojies = new List<string>();
            var coolnes = 0;
            foreach (var item in digits)
            {
                coolnesFactor *= int.Parse(item.Groups["number"].Value);
            }
            foreach (var emoji in emojies)
            {
                for (int i = 0; i < emoji.Value.Length; i++)
                {
                    if (char.IsLetter(emoji.Value[i]))
                    {
                        coolnes += emoji.Value[i];
                    }
                }
                if (coolnes > coolnesFactor)
                {
                    finalEmojies.Add(emoji.Value);
                }
                coolnes = 0;
            }

            Console.WriteLine($"Cool threshold: {coolnesFactor}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            if (finalEmojies.Count > 0);
            {
                Console.WriteLine(string.Join(Environment.NewLine, finalEmojies));
            }
            



        }
    }
}
