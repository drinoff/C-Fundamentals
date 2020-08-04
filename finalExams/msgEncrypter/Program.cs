using System;
using System.Text;
using System.Text.RegularExpressions;

namespace msgEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                var pattern = @"(\*|@)(?<tag>[A-Z]{1}[a-z]{2,})\1: \[(?<letter1>[A-Za-z])\]\|\[(?<letter2>[A-Za-z])\]\|\[(?<letter3>[A-Za-z])\]\|$";
                var validMsg = Regex.Match(input,pattern);
                if(!validMsg.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    var tag = validMsg.Groups["tag"].Value;
                    var letter1 = validMsg.Groups["letter1"].Value;
                    var letter2 = validMsg.Groups["letter2"].Value;
                    var letter3 = validMsg.Groups["letter3"].Value;
                    var letters = letter1 + letter2 + letter3;
                    var chars = letters.ToCharArray();
                    var sb = new StringBuilder();
                    for (int j = 0; j < chars.Length; j++)
                    {
                        sb.Append((int)chars[j]);
                        sb.Append(" ");
                    }
                    Console.WriteLine($"{tag}: {sb.ToString()}");
                }
                input = Console.ReadLine();
            }
        }
    }
}
