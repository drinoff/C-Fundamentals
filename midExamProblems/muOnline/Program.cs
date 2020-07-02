using System;
using System.Linq;

namespace muOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = 100;
            var bitcoins = 0;
            var rooms = Console.ReadLine().Split("|").ToList();
            var isDead = false;
            for (int i = 0; i < rooms.Count; i++)
            {
                var command = rooms[i].Split();
                var thing = command[0];
                var number = int.Parse(command[1]);
                switch (thing)
                {
                    case "potion":

                        if (health + number > 100)
                        {

                            Console.WriteLine($"You healed for {100-health} hp.");
                            health = 100;
                        }
                        else
                        {
                            health += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");

                        break;
                    case "chest":
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        health -= number;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {thing}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {thing}.");
                            Console.WriteLine($"Best room: {i+1}");
                            isDead = true;
                            Environment.Exit(0);
                        }
                        break;
                }
            }
            if (!isDead)
            {
                Console.WriteLine("You've made it!"); 
                Console.WriteLine($"Bitcoins: {bitcoins}"); 
                Console.WriteLine($"Health: {health}"); 
            }
        }
    }
}
