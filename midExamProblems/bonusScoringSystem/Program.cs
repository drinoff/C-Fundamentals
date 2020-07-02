using System;
using System.Collections.Generic;
using System.Linq;

namespace bonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentCount = int.Parse(Console.ReadLine());
            var lectureCount = int.Parse(Console.ReadLine());
            var additionalBonus = int.Parse(Console.ReadLine());
            
            var maxBonus = 0;
            var studentAttendace = 0;

            for (int i = 0; i < studentCount; i++)
            {
                var attendances = int.Parse(Console.ReadLine());
                var totalBonus = (attendances * 1.0 / lectureCount) * (5 + (additionalBonus));
                var bonus = (int)Math.Ceiling(totalBonus);
                if (bonus >= maxBonus)
                {
                    maxBonus = bonus;
                    studentAttendace = attendances;
                }
            }                        
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {studentAttendace} lectures.");
        }
    }
}
