using System;

namespace Coins
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    double change = double.Parse(Console.ReadLine());
        //    //double change = 1.23d;

        //    int coin = 0;

        //    while (change > 0)
        //    {
        //        if (change >= 2) change = Math.Round(change - 2.0, 2);
        //        else if (change >= 1) change = Math.Round(change - 1.0, 2);
        //        else if (change >= 0.5) change = Math.Round(change - 0.5, 2);
        //        else if (change >= 0.2) change = Math.Round(change - 0.2, 2);
        //        else if (change >= 0.1) change = Math.Round(change - 0.1, 2);
        //        else if (change >= 0.05) change = Math.Round(change - 0.05, 2);
        //        else if (change >= 0.02) change = Math.Round(change - 0.02, 2);
        //        else if (change >= 0.01) change = Math.Round(change - 0.01, 2);
        //        coin++;
        //    }

        //    Console.WriteLine(coin);
        //}


        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            //double change = 1.23d;

            int coin = 0;

            while (change > 0)
            {
                if (change >= 2.0m) change -= 2.0m;
                else if (change >= 1.0m) change -= 1.00m;
                else if (change >= 0.5m) change -= 0.50m;
                else if (change >= 0.2m) change -= 0.20m;
                else if (change >= 0.1m) change -= 0.10m;
                else if (change >= 0.05m) change -= 0.05m;
                else if (change >= 0.02m) change -= 0.02m;
                else if (change >= 0.01m) change -= 0.01m;
             coin++;
            }

            Console.WriteLine(coin);
        }
    }
}
