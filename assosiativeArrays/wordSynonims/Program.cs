using System;
using System.Collections.Generic;

namespace wordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonims = new Dictionary<string, List<string>>();

            

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (wordSynonims.ContainsKey(word)==false)
                {
                    wordSynonims.Add(word, new List<string>());
                }
                wordSynonims[word].Add(synonim);
                
            }
            foreach (var item in wordSynonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
                        
        }
    }
}
