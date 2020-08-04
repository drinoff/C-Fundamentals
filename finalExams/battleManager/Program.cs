using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace battleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input !="Results")
            {
                var command = input.Split(":");
                var action = command[0];
                switch (action)
                {
                    case"Add":
                        var person = command[1];
                        var health = int.Parse(command[2]);
                        var energy = int.Parse(command[3]);
                        if(persons.ContainsKey(person))
                        {
                            persons[person][0] += health; 
                        }
                        else
                        {
                            persons.Add(person, new List<int> { health, energy });
                        }
                        break;
                    case "Attack":
                        var attacker = command[1];
                        var defender = command[2];
                        var damage = int.Parse(command[3]);
                        if(persons.ContainsKey(attacker)&&persons.ContainsKey(defender))
                        {
                            persons[defender][0] -= damage;
                            persons[attacker][1] -= 1;
                            if(persons[defender][0]<=0)
                            {
                                persons.Remove(defender);
                                Console.WriteLine($"{defender} was disqualified!");
                            }
                            if(persons[attacker][1]<=0)
                            {
                                persons.Remove(attacker);
                                Console.WriteLine($"{attacker} was disqualified!");
                            }
                        }
                        break;
                    case "Delete":
                        var username = command[1];
                        if(username == "All")
                        {
                            persons.Clear();
                        }
                        else
                        {
                            persons.Remove(username);
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"People count: {persons.Count}");
            foreach (var person in persons.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
