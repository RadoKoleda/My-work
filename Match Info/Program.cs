using System;

namespace Match_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string Team = Console.ReadLine();
            int numberMatches = int.Parse(Console.ReadLine());
            int withPenalties = 0;
            int gamesWithAditionalTime = 0;
            double totalMins = 0;

            for (int i = 1; i <= numberMatches; i++)
            {
                double minutes = double.Parse(Console.ReadLine());
                totalMins += minutes;

                if (minutes > 120)
                {
                    withPenalties++;
                }
                else if (minutes > 90)
                {
                    gamesWithAditionalTime++;
                }
            }
            double averange = totalMins / numberMatches;
            Console.WriteLine($"{Team} has played {totalMins} minutes. Average minutes per game: {averange:f2}");
            Console.WriteLine($"Games with penalties: {withPenalties}");
            Console.WriteLine($"Games with additional time: {gamesWithAditionalTime}");
        }
    }
}
