using System;
using System.Linq;

namespace theFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            var input = Console.ReadLine();

            while (input !="Stop")
            {
                var command = input.Split();
                var action = command[0];

                switch (action)
                {
                    case "Delete":
                        var index = int.Parse(command[1]);
                        if (index + 1 < words.Count )
                        {
                            words.RemoveAt(index + 1);
                        }
                        break;
                    case "Swap":
                        var word1 = command[1];
                        var word2 = command[2];
                        var index1 = words.IndexOf(word1);
                        var index2 = words.IndexOf(word2);
                        if (words.Contains(word1) && words.Contains(word2))
                        {
                            var temp = words[index1];
                            words[index1] = words[index2];
                            words[index2] = temp;
                        }
                        break;
                    case "Put":
                        var word = command[1];
                        index = int.Parse(command[2]);
                        if (index - 1 <= words.Count && index-1 >= 0)
                        {
                            words.Insert(index-1,word);
                        }
                        break;
                    case "Sort":
                       words =  words.OrderByDescending(x => x).ToList();
                        break;
                    case "Replace":
                        word1 = command[1];
                        word2 = command[2];
                        index = words.IndexOf(word2);
                        if (words.Contains(word2))
                        {
                            words[index] = word1;
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",words));

        }
    }
}
