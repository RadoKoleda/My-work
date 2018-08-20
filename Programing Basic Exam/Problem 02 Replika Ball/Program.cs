using System;

namespace Problem_02_Replika_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshurtPrice = double.Parse(Console.ReadLine());
            double targetPrice = double.Parse(Console.ReadLine());

            double shorts = tshurtPrice * 0.75;
            double socs = shorts * 0.2;
            double DaFakingBUTONKIbate = 2 * (shorts + tshurtPrice);
            double NaTiTaaaSmetka = tshurtPrice + socs + shorts + DaFakingBUTONKIbate;
            double aaaNeMersi = NaTiTaaaSmetka - (NaTiTaaaSmetka * 0.15);


            if (aaaNeMersi > targetPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {aaaNeMersi:f2} lv.");
            }
            else
            {
                double diff = targetPrice - aaaNeMersi;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {diff:f2} lv. more.");
            }
        }
    }
}
