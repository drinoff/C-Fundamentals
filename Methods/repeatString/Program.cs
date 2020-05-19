using System;

namespace repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.Write(RepeatString(word, n));
        }

        static string RepeatString(string word, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += word;
                
            }
            return result;
        }
    }
}
