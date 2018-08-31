using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] comander = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> inputTaken = new List<int>();
            for (int i = 0; i < comander[0]; i++)
            {
                inputTaken.Add(input[i]);
            }
            for (int i = 0; i < comander[1]; i++)
            {
                inputTaken.RemoveAt();
            }
            for (int i = 0; i < inputTaken.Count; i++)
            {
                if (inputTaken[i] == comander[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
