using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace teamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var catalogue = new Catalogue();
            while (input != "End")
            {
                var vehicle = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var type = vehicle[0];
                var model = vehicle[1];
                var color = vehicle[2];
                var hp = int.Parse(vehicle[3]);

                switch (type)
                {
                    case "car":
                        Car car = new Car()
                        {
                            Type = "Car",
                            Model = model,
                            Color = color,
                            HP = hp
                        };
                        catalogue.Cars.Add(car);
                        break;
                    case "truck":
                        Truck truck = new Truck()
                        {
                            Type = "Truck",
                            Model = model,
                            Color = color,
                            HP = hp
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                bool isCar = catalogue.Cars.Any(x => x.Model == input);
                if (isCar)
                {
                    var currentVehicle = catalogue.Cars.Find(x => x.Model == input);
                    Console.WriteLine($"Type: {currentVehicle.Type}");
                    Console.WriteLine($"Model: {currentVehicle.Model}");
                    Console.WriteLine($"Color: {currentVehicle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehicle.HP}");
                }
                else
                {
                    var currentVehicle = catalogue.Trucks.Find(x => x.Model == input);
                    Console.WriteLine($"Type: {currentVehicle.Type}");
                    Console.WriteLine($"Model: {currentVehicle.Model}");
                    Console.WriteLine($"Color: {currentVehicle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehicle.HP}");
                }

                input = Console.ReadLine();
            }
            if (catalogue.Cars.Count > 0)
            {
                var avgCarHP = catalogue.Cars.Sum(x => x.HP) * 1.0 / catalogue.Cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
                
            }
            if (catalogue.Trucks.Count > 0)
            {
                var avgTrucksHP = catalogue.Trucks.Sum(x => x.HP) * 1.0 / catalogue.Trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
                
            }

        }
    }
    public class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
    public class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
    public class Catalogue
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
