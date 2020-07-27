using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(", ").ToList();
            var input = Console.ReadLine();
            
            var lower = @"[A-Za-z]";
            var names = new Dictionary<string,int>();
            
            while (input !="end of race")
            {
                var letters = Regex.Matches(input, lower).ToList();
                var digits = Regex.Matches(input, @"\d").ToList();
                var sum = 0;

                for (int i = 0; i < digits.Count; i++)
                {
                    sum += int.Parse(digits[i].Value);
                }
                
                var currentName = string.Join("", letters);
                if (participants.Contains(currentName))
                {
                    if (!names.ContainsKey(currentName))
                    {
                        names.Add(currentName, sum);
                    }
                    else
                    {
                        names[currentName] += sum;
                    }
                    currentName = string.Empty;
                    sum = 0;
                }
                input = Console.ReadLine();
                
            }
            var result = names.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,y=>y.Value);
            var result2 = result.Keys.ToList();

            Console.WriteLine($"1st place: {result2[0]}");
            Console.WriteLine($"2nd place: {result2[1]}");
            Console.WriteLine($"3rd place: {result2[2]}");
        }
    }
}
