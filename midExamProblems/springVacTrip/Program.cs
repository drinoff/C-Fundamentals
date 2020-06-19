using System;

namespace springVacTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var people = int.Parse(Console.ReadLine());
            var priceFuelPerKM = double.Parse(Console.ReadLine());
            var foodExpencesPerPersonPerDay = double.Parse(Console.ReadLine());
            var hotelPricePerpersonProNight = double.Parse(Console.ReadLine());
            var noBudget = false;
            

            if (people > 10)
            {
                hotelPricePerpersonProNight *= 0.75;    
            }
            var grpHotelPrice = people * hotelPricePerpersonProNight*days;
            var grpFoodPrice = people * foodExpencesPerPersonPerDay * days;
            var currentExpences = grpFoodPrice + grpHotelPrice;

            for (int i = 1; i <= days; i++)
            {
                var KMperDay = double.Parse(Console.ReadLine());

                var expencesForFuel = KMperDay * priceFuelPerKM;
                currentExpences += expencesForFuel;
                if (i % 3 == 0|| i % 5 == 0)
                {
                    currentExpences += currentExpences * 0.4;
                }
                if (i % 7 == 0)
                {
                    currentExpences -= currentExpences / people;
                }
                
                if (budget < currentExpences)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {Math.Abs(budget - currentExpences):f2}$ more.");
                    noBudget = true;
                    break;
                }

            }
           
            if (noBudget == false)
            {
                Console.WriteLine($"You have reached the destination. You have {(budget- currentExpences):f2}$ budget left.");
            }


        }
    }
}
