using System;

namespace Daily_earn
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDay = int.Parse(Console.ReadLine());
            double dailyPayment = double.Parse(Console.ReadLine());
            double USDtoBGN = double.Parse(Console.ReadLine());

            double mountly = workDay * dailyPayment;
            double yearly = mountly * 12 + mountly * 2.5;
            double danak = yearly - (yearly * 0.25);
            double BGN = danak * USDtoBGN;
            double final = BGN / 365;
            Console.WriteLine($"{final:F2}");
        }
    }
}
