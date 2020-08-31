using System;
using System.Linq;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var reversed = input.ToCharArray();
                Array.Reverse(reversed);
                var result = new string (reversed);

                Console.WriteLine($"{input} = {result}");
                input = Console.ReadLine();
            }
        }
    }
}
