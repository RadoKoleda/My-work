using System;
using System.Linq;

namespace Rotate_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] sum = new int[line.Length];

            for (int i = 0; i < rotation; i++)
            {
                int[] lineRotated = new int[line.Length];
                for (int j = 0; j < line.Length; j++)
                {
                    if (j == 0)
                    {
                        lineRotated[j] = line[line.Length - 1];
                    }
                    else
                    {
                        lineRotated[j] = line[j - 1];
                    }
                    sum[j] += lineRotated[j];
                }
                line = lineRotated;
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}
