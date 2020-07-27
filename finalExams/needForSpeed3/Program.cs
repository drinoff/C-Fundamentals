using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace needForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                var currCarInfo = Console.ReadLine().Split("|");
                Car car = new Car
                {
                    Make = currCarInfo[0],
                    Mileage = int.Parse(currCarInfo[1]),
                    Fuel = int.Parse(currCarInfo[2])
                };
                cars.Add(car);
            }
            var input = Console.ReadLine();
            while (input != "Stop")
            {
                var command = input.Split(" : ");
                var action = command[0];
                switch (action)
                {
                    case "Drive":
                        var make = command[1];
                        var distance = int.Parse(command[2]);
                        var fuel = int.Parse(command[3]);
                        var currentCar = cars.Find(x => x.Make == make);
                        if (fuel > currentCar.Fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            currentCar.Fuel -= fuel;
                            currentCar.Mileage += distance;
                            Console.WriteLine($"{currentCar.Make} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (currentCar.Mileage >= 100000)
                            {
                                cars.Remove(currentCar);
                                Console.WriteLine($"Time to sell the {currentCar.Make}!");
                            }
                        }
                        break;
                    case "Refuel":
                        make = command[1];
                        fuel = int.Parse(command[2]);
                        currentCar = cars.Find(x => x.Make == make);
                        var fuelNeeded = 75 - currentCar.Fuel;

                        currentCar.Fuel += fuel;
                        if (currentCar.Fuel > 75)
                        {
                            var fueled = fuel - (currentCar.Fuel - 75);
                            currentCar.Fuel = 75;
                            Console.WriteLine($"{currentCar.Make} refueled with {fueled} liters");
                        }
                        else
                        {
                            Console.WriteLine($"{currentCar.Make} refueled with {fuel} liters");
                        }
                        break;
                    case "Revert":
                        make = command[1];
                        var kilometers = int.Parse(command[2]);
                        currentCar = cars.Find(x => x.Make == make);
                        currentCar.Mileage -= kilometers;
                        if(currentCar.Mileage<10000)
                        {
                            currentCar.Mileage = 10000;

                        }
                        else
                        {

                            Console.WriteLine($"{currentCar.Make} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            var result = cars.OrderByDescending(x => x.Mileage).ThenBy(x => x.Make);
            foreach (var car in result)
            {
                Console.WriteLine($"{car.Make} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }

        }
        public class Car
        {
            public string Make { get; set; }
            public int Fuel { get; set; }
            public int Mileage { get; set; }
        }
    }
}
