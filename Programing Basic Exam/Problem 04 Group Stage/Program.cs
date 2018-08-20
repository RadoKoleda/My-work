using System;

namespace Problem_04_Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string darjava = Console.ReadLine();
            int matchPlayed = int.Parse(Console.ReadLine());
            int points = 0;
            int Me = 0;
            int You = 0;

            for (int i = 1; i <= matchPlayed; i++)
            {
                int goalWin = int.Parse(Console.ReadLine());
                int goalLose = int.Parse(Console.ReadLine());
                if (goalWin > goalLose)
                {
                    points += 3;
                    Me += goalWin;
                    You += goalLose;
                }
                else if (goalWin == goalLose)
                {
                    points += 1;
                    Me += goalWin;
                    You += goalLose;
                }
                else
                {
                    Me += goalWin;
                    You += goalLose;
                }
            }

            int diff = Me - You;

            if (Me >= You)
            {
                Console.WriteLine($"{darjava} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {diff}.");
            }
            else
            {
                Console.WriteLine($"{darjava} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {diff}.");
            }
        }
    }
}
