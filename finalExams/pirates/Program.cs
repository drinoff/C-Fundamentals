using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityInfo = Console.ReadLine();
            var cities = new List<City>();
            while (cityInfo != "Sail")
            {
                var splittedCity = cityInfo.Split("||");
                if (cities.Any(x => x.Name == splittedCity[0]))
                {
                    var currentCity = cities.Find(x => x.Name == splittedCity[0]);
                    currentCity.Gold += int.Parse(splittedCity[2]);
                    currentCity.Population += int.Parse(splittedCity[1]);
                }
                else
                {
                    City city = new City
                    {
                        Name = splittedCity[0],
                        Population = int.Parse(splittedCity[1]),
                        Gold = int.Parse(splittedCity[2])
                    };
                    cities.Add(city);
                }
            cityInfo = Console.ReadLine();
            }

            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split("=>");
                var action = command[0];
                switch (action)
                {
                    case "Plunder":
                        var town = command[1];
                        var people = int.Parse(command[2]);
                        var gold = int.Parse(command[3]);
                        var currentCity = cities.Find(x => x.Name == town);
                        currentCity.Gold -= gold;
                        currentCity.Population -= people;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        if(currentCity.Gold == 0 || currentCity.Population == 0)
                        {
                            cities.Remove(currentCity);
                            Console.WriteLine($"{currentCity.Name} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        town = command[1];
                        gold = int.Parse(command[2]);
                        if(gold>0)
                        {
                            currentCity = cities.Find(x => x.Name == town);
                            currentCity.Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {currentCity.Gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            if(cities.Count==0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(x => x.Gold).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
        }
        public class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
    }
}
