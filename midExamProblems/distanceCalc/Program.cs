using System;

namespace distanceCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var stepsMade = int.Parse(Console.ReadLine());
            var stepLength = double.Parse(Console.ReadLine());
            var distanceNeeded = int.Parse(Console.ReadLine()) * 100;

            var shortStepDistance = (stepsMade / 5) * (stepLength * 0.7);
            var distanceCovered = (stepsMade - stepsMade / 5) * stepLength + shortStepDistance;
            var percentCovered = (distanceCovered / distanceNeeded) * 100;

            Console.WriteLine($"You travelled {percentCovered:f2}% of the distance!");
        }
    }
}
