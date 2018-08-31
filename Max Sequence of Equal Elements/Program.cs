using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> container = new List<int>();
            List<int> output;
            int bestCount = 0;

            for (int i = 1; i <= input.Length; i++)
            {
                if(input[i - 1] == input[i])
                {
                    container.Add(input[i - 1]);
                    container.Add(input[i]);
                }
                else
                {

                }
            }
        }
    }
}
