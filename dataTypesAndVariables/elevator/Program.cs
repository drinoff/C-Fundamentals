using System;
using System.Dynamic;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = Console.ReadLine();
            var capacity = Console.ReadLine();

            var course = int.Parse(persons) * 1.0 / int.Parse(capacity);
            Console.WriteLine(Math.Ceiling(course));
        }
    }
}
