using System;
using System.Linq;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = Console.ReadLine().Split(", ").ToList();

            var input = Console.ReadLine();

            while (input != "Craft!")
            {
                var command = input.Split(" - ");
                var action = command[0];

                switch (action)
                {
                    case "Collect":
                        var item = command[1];
                        if (!journal.Contains(item))
                        {
                            journal.Add(item);
                        }
                        break;
                    case "Drop":
                        item = command[1];
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        var items = command[1].Split(":");
                        var oldItem = items[0];
                        var newItem = items[1];
                        if(journal.Contains(oldItem))
                        {
                            var index = journal.IndexOf(oldItem);
                            if (index + 1 == journal.Count)
                            {
                                journal.Add(newItem);
                            }
                            else
                            {
                                journal.Insert(index + 1, newItem);
                            }
                        }
                        break;
                    case "Renew":
                        item = command[1];
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                            journal.Add(item);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
