using System;
using System.Text.RegularExpressions;

namespace matchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var match = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var matches = Regex.Matches(input, match);
            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
