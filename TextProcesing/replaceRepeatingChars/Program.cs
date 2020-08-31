using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace replaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = new Regex("(.)\\1+");

            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}
