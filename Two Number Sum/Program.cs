using System;

namespace Two_Number_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = start; i >= stop; i--)
            {
                for (int j = start; j >= stop; j--)
                {
                    if (i + j == magicNumber)
                    {
                        count++;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        return;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
