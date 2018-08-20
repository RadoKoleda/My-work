using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenth = int.Parse(Console.ReadLine());

            int cake = widht * lenth;

            while (cake >= 0)
            {
                string take = Console.ReadLine();

                if (take == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }
                else
                {
                    int well = int.Parse(take);
                    if (cake - well <= 0)
                    {
                        int diff = Math.Abs(cake - well);
                        Console.WriteLine($"No more cake left! You need {diff} pieces more.");
                        break;
                    }
                    else
                    {
                        cake -= well;
                    }
                }
            }
        }
    }
}
