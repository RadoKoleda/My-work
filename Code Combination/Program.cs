using System;

namespace Code_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            long currentTurn = 1;

            int number = int.Parse(Console.ReadLine());

            for (char i = 'B'; i <= 'L'; i = (char)((int)i + 2))
            {
                for (char j = 'f'; j >= 'a'; j--)
                {
                    for (char f = 'A'; f <= 'C'; f++)
                    {
                        for (long n = 1; n <= 10; n++)
                        {
                            for (long h = 10; h >= 1; h--)
                            {
                                if (currentTurn == number)
                                {
                                    Console.WriteLine($"Ticket combination: {i}{j}{f}{n}{h}");
                                    long price = i + j + f + n + h;
                                    Console.WriteLine($"Prize: {price} lv.");
                                    return;
                                }
                                currentTurn += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
