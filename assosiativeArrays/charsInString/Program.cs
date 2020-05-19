using System;
using System.Collections.Generic;

namespace charsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char item in text)
            {
                if (item != ' ')
                {
                    if (chars.ContainsKey(item) == false)
                    {
                        chars.Add(item, 1);
                    }
                    else
                    {
                        chars[item]++;
                    }
                }
            }
            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
