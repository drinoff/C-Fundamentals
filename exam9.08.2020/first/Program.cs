using System;
using System.Linq;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            var stops = Console.ReadLine();
            var input = Console.ReadLine();
            while (input != "Travel")
            {
                var command = input.Split(":");
                var action = command[0];
                switch (action)
                {
                    case "Add Stop":
                        var index = int.Parse(command[1]);
                        var stop = command[2];
                        if(index >=0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, stop);
                            Console.WriteLine(stops);
                        }
                       break;
                    case "Remove Stop":
                        var startIndex = int.Parse(command[1]);
                        var endIndex = int.Parse(command[2]);
                        if(startIndex>=0 && startIndex< stops.Length && endIndex>=0 && endIndex<stops.Length)
                        {
                            stops = stops.Remove(startIndex, (endIndex - startIndex)+1);
                        }
                        Console.WriteLine(stops);
                        break;
                    case "Switch":
                        var oldString = command[1];
                        var newString = command[2];
                        if(stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                        }
                        Console.WriteLine(stops);
                        break;
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
        
    }
}
