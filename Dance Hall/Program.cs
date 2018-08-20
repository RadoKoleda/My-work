using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double volume = (L * 100) * (W * 100);
            double wardrobe = ((A * 100) * (A * 100));
            double lazySitter = volume / 10;

            double freeSpace = volume - wardrobe - lazySitter;
            double danceMan = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Round(danceMan));
        }
    }
}
