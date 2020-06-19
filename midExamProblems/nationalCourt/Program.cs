using System;

namespace nationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal employe1 = int.Parse(Console.ReadLine());
            decimal employe2 = int.Parse(Console.ReadLine());
            decimal employe3 = int.Parse(Console.ReadLine());

            decimal peopleCount = int.Parse(Console.ReadLine());

            var forOneHour = employe1 + employe2 + employe3;
            decimal days = 0;

            decimal timeNeeded = Math.Ceiling(peopleCount / forOneHour);
            var timeWasted = Math.Ceiling(timeNeeded / 4);
            var finalTime = timeNeeded + timeWasted;
            
            
            if (timeNeeded <= 3)
            {
                Console.WriteLine($"Time needed: {timeNeeded}h.");
            }
            else
            {
                Console.WriteLine($"Time needed: {finalTime}h.");
            }
        }
    }
}
