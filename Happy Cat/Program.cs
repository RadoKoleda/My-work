using System;

namespace Happy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int happyDays = int.Parse(Console.ReadLine());
            int happyHour = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= happyDays; i++)
            {
                double parking = 0;
                for (int j = 1; j <= happyHour; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        parking = parking + 2.5;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        parking = parking + 1.25;
                    }
                    else
                    {
                        parking = parking + 1;
                    }
                }
                total = total + parking;
                Console.WriteLine($"Day: {i} - {parking:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
