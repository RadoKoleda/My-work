using System;

namespace Problem_01_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketGO = double.Parse(Console.ReadLine());
            double ticketCOMEBACK = double.Parse(Console.ReadLine());
            double ticketOneMatch = double.Parse(Console.ReadLine());
            double numberOfMatches = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double ticketSum = (6 * (ticketGO + ticketCOMEBACK));
            double ticketSumSecondTime = ticketSum - (ticketSum * (discount / 100));
            double MatchPrise = 6 * (ticketOneMatch * numberOfMatches);
            double totalSum = (ticketSumSecondTime + MatchPrise);
            double totalSumForOne = totalSum / 6;

            Console.WriteLine($"Total sum: {totalSum:f2} lv.");
            Console.WriteLine($"Each friend has to pay {totalSumForOne:f2} lv.");
        }
    }
}
