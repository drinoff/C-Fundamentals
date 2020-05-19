using System;
using System.Linq;

namespace largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var result = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .Reverse()
                .Take(3);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
