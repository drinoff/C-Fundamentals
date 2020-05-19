using System;
using System.Collections.Generic;
using System.Linq;

namespace listManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();


            while (input != "end")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commands[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]),int.Parse(commands[1]));
                        break;
                        
                }

                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
