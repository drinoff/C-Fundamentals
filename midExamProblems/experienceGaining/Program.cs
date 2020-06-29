using System;

namespace experienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var experience = double.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());
            var totalXP = 0.0;
            for (int i = 1; i <= battles; i++)
            {
                var xpGained = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                     xpGained*= 1.15;
                }                            
                if (i % 5 == 0)
                {
                    xpGained *= 0.9;                   
                }
                totalXP += xpGained;
                if (totalXP >= experience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    Environment.Exit(0);
                }                                
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {experience - totalXP:f2} more needed.");
        }
    }
}
