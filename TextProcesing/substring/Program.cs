using System;
using System.Text.RegularExpressions;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = Console.ReadLine().ToLower();
            var strToMatch = Console.ReadLine();
            var result = string.Empty;
            for (int i = 0; i < 10; i++)
            {            
                strToMatch = Regex.Replace(strToMatch, match, "");
            }
            Console.WriteLine(strToMatch);
        }
    }
}
