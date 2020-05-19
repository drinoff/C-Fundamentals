using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

namespace vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            Console.WriteLine(GetVowelCounts(str));
        }
        static int GetVowelCounts(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    counter += 1;
            
            }
            return counter;
        }
    }
}
 