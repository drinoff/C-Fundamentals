using System;
using System.Collections.Generic;
using System.Linq;

namespace orderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var persons = new List<Person>();
            while (input!="End")
            {
                var personDetails = input.Split().ToArray();
                var name = personDetails[0];
                var id = personDetails[1];
                var age = int.Parse(personDetails[2]);

                var person = new Person()
                {
                  Name = name,
                  Id = id,
                  Age = age
                };
                persons.Add(person);

                input = Console.ReadLine();
            }
            foreach (var person in persons.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }
        public class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
            
      
        }
    }
}
