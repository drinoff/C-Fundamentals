using System;
using System.Collections.Generic;
using System.Resources;

namespace minerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> resources = new Dictionary<string, int>();
            
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int amount = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource) == false)
                {
                    resources.Add(resource,0);
                }
                resources[resource] += amount;             
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
