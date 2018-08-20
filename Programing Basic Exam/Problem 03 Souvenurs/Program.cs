using System;

namespace Souvenurs
{
    class Program
    {
        static void Main(string[] args)
        {
            double flagcheta = 0;
            double shapki = 0;
            double plakati = 0;
            double stikeri = 0;

            string darjava = Console.ReadLine();
            string suvenir = Console.ReadLine();
            double broika = double.Parse(Console.ReadLine());


            if (darjava == "Argentina")
            {
                if (suvenir == "flags")
                {
                    flagcheta = 3.25 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {flagcheta:f2} lv.");
                }
                else if (suvenir == "caps")
                {
                    shapki = 7.20 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {shapki:f2} lv.");
                }
                else if (suvenir == "posters")
                {
                    plakati = 5.10 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {plakati:f2} lv.");
                }
                else if (suvenir == "stickers")
                {
                    stikeri = 1.25 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {stikeri:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (darjava == "Brazil")
            {
                if (suvenir == "flags")
                {
                    flagcheta = 4.20 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {flagcheta:f2} lv.");
                }
                else if (suvenir == "caps")
                {
                    shapki = 8.50 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {shapki:f2} lv.");
                }
                else if (suvenir == "posters")
                {
                    plakati = 5.35 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {plakati:f2} lv.");
                }
                else if (suvenir == "stickers")
                {
                    stikeri = 1.20 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {stikeri:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (darjava == "Croatia")
            {
                if (suvenir == "flags")
                {
                    flagcheta = 2.75 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {flagcheta:f2} lv.");
                }
                else if (suvenir == "caps")
                {
                    shapki = 6.90 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {shapki:f2} lv.");
                }
                else if (suvenir == "posters")
                {
                    plakati = 4.95 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {plakati:f2} lv.");
                }
                else if (suvenir == "stickers")
                {
                    stikeri = 1.10 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {stikeri:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (darjava == "Denmark")
            {
                if (suvenir == "flags")
                {
                    flagcheta = 3.10 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {flagcheta:f2} lv.");
                }
                else if (suvenir == "caps")
                {
                    shapki = 6.50 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {shapki:f2} lv.");
                }
                else if (suvenir == "posters")
                {
                    plakati = 4.80 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {plakati:f2} lv.");
                }
                else if (suvenir == "stickers")
                {
                    stikeri = 0.90 * broika;
                    Console.WriteLine($"Pepi bought {broika} {suvenir} of {darjava} for {stikeri:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
