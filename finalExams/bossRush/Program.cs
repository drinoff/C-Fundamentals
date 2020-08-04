using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace bossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            for (int i = 0; i < linesCount; i++)
            {
                var pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";
                var validBoss = Regex.Match(input, pattern);
                if (validBoss.Success)
                {
                    Console.WriteLine($"{validBoss.Groups["name"].Value}, The {validBoss.Groups["title"].Value}");
                    Console.WriteLine($">> Strength: {validBoss.Groups["name"].Value.Count()}");
                    Console.WriteLine($">> Armour: {validBoss.Groups["title"].Value.Count()}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
