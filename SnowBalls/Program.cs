using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int forLoop = int.Parse(Console.ReadLine());
            double bestValue = 0;
            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 0; i < forLoop; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double sum = Math.Pow(snowballSnow / snowballTime, snowballQuality);

                if (sum > bestValue)
                {
                    bestValue = sum;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {bestValue} ({quality})");

        }
    }
}
