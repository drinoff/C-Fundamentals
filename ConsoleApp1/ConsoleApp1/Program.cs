using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSequence = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            
            var stringseq = string.Join("", initialSequence);
            var joined = Regex.Replace(stringseq, @"\s+", "");
            var arrayJoined = joined.ToCharArray();
            
            Console.WriteLine(string.Join(" ", arrayJoined));
        }
    }
}