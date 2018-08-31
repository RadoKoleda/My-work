using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();
            List<int> midle = new List<int>();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= ((input.Length / 4) - 1))
                {
                    leftSide.Add(input[i]);
                }
                else if (i <= (((input.Length / 2) - 1) + leftSide.Count))
                {
                    midle.Add(input[i]);
                }
                else
                {
                    rightSide.Add(input[i]);
                }
            }
            leftSide.Reverse();
            rightSide.Reverse();

            for (int i = 0; i < leftSide.Count; i++)
            {
                midle[i] += leftSide[i];
                midle[(leftSide.Count + i)] += rightSide[i];
            }
            Console.WriteLine(String.Join(' ', midle));
        }
    }
}
