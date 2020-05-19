using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            var userPlate = new Dictionary<string, string>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "register")
                {
                    string username = command[1];
                    string licensePlate = command[2];
                    if (userPlate.ContainsKey(username) == false)
                    {
                        userPlate.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                }
                else
                {
                    string username = command[1];                    
                    if (userPlate.ContainsKey(username))
                    {
                        userPlate.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }

            }
            foreach (var user in userPlate)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
