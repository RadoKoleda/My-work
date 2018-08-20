using System;

namespace Cash_and_Coins_DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin1 = int.Parse(Console.ReadLine());
            int coin2 = int.Parse(Console.ReadLine());
            int cash5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coin1; i++)
            {
                for (int j = 0; j <= coin2; j++)
                {
                    for (int f = 0; f <= cash5; f++)
                    {
                        if ((i * 1) + (j * 2) + (f * 5) == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {f} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
