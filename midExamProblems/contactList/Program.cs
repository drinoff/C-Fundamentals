using System;
using System.Linq;

namespace contactList
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                var action = command[0];

                switch (action)
                {
                    case "Add":
                        var contact = command[1];
                        var index = int.Parse(command[2]);
                        if (!contacts.Contains(contact))
                        {
                            contacts.Add(contact);
                        }
                        else
                        {
                            if (index >= 0 && index < contacts.Count)
                            {
                                contacts.Insert(index, contact);
                            }
                        }
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.RemoveAt(index);
                        }
                        break;
                    case "Export":
                        index = int.Parse(command[1]);
                        var count = int.Parse(command[2]);
                        if (index + count > contacts.Count)
                        {
                            count = contacts.Count - index;
                        }
                        Console.WriteLine(string.Join(" ", contacts.Skip(index).Take(count)));
                        break;
                    case "Print":
                        var type = command[1];
                        if (type == "Normal")
                        {
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            contacts.Reverse();
                            Console.WriteLine($"Contacts: {string.Join(" ",contacts)}");
                            System.Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}
