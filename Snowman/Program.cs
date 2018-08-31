using System;
using System.Linq;

namespace Snowman
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int attacker;
                if (i == 3)
                    attacker = i + 2;
                else
                    attacker = i;

                int target = input[i];

                if (target > input.Length)
                    target = target % input.Length;

                int diff = Math.Abs(attacker - target);

                if (diff == 0)
                {
                    Console.WriteLine($"{attacker} performed harakiri");
                    int[] hui = new int[i];
                    for (int j = 0; j < hui.Length; j++)
                        hui[j] = input[j];
                    input = hui;
                    i = -1;
                }
                else if (diff % 2 == 1)
                {
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    int[] hui = new int[i];
                    for (int j = 0; j < hui.Length; j++)
                        hui[j] = input[j];
                    input = hui;
                    i = -1;
                }
                else if (diff % 2 == 0)
                {
                    Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                }
            }
        }
    }
}
