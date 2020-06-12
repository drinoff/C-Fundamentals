using System;

namespace disneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            var journeyCost = double.Parse(Console.ReadLine());
            var numberMonths = int.Parse(Console.ReadLine());

            var monthlySavings = journeyCost * 0.25;
            var sum = 0.0;
            var monthCounter = 1;

            for (int i = 1; i <= numberMonths; i++)
            {

                if (monthCounter % 2 != 0)
                {
                    if (monthCounter != 1)
                    {
                        sum *= 0.84;
                    }
                }
                if (monthCounter == 4 || monthCounter == 8 || monthCounter == 12)
                {
                    sum *= 1.25;
                }
                sum += monthlySavings;
                monthCounter++;
            }
            if (sum >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {sum - journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost-sum:f2}lv. more.");
            }
        }
    }
}
