using System;
using System.Numerics;

namespace snowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowBallCount = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = new BigInteger();
            BigInteger bestSnowBall = -1;
            var bestSnowBallSnow = 0;
            var bestSnowBallTime = 0;
            var bestSnowBallQuality = 0;

            for (int i = 0; i < snowBallCount; i++)
            {
                var snowBallSnow = int.Parse(Console.ReadLine());
                var snowBallTime = int.Parse(Console.ReadLine());
                var snowBallQuality = int.Parse(Console.ReadLine());

                snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowBallValue >= bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestSnowBallSnow = snowBallSnow;
                    bestSnowBallTime = snowBallTime;
                    bestSnowBallQuality = snowBallQuality;
                }

            }
            if (snowBallCount <= 0)
            { }
            else
            {
                Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestSnowBall} ({bestSnowBallQuality})");
            }
        }
    }
}