using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" <:> ").ToArray();
            Dictionary<string, Dictionary<string, int>> dwarf = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "Once upon a time")
            {
                if (dwarf.ContainsKey(input[1]))
                {
                    if (dwarf[input[1]].ContainsKey(input[0]))
                    {
                        dwarf[input[1]][input[0]] = int.Parse(input[2]);
                    }
                    else
                    {
                        dwarf[input[1]].Add(input[0], int.Parse(input[2]));
                    }
                }
                else if (dwarf.ContainsKey(input[1]) == false)
                {
                    dwarf.Add(input[1], new Dictionary<string, int>());
                    dwarf[input[1]].Add(input[0], int.Parse(input[2]));
                }
                input = Console.ReadLine().Split(" <:> ").ToArray();
            }

            foreach (var item in dwarf.OrderByDescending(x => x.Key.Count()))
            {
                foreach (var kur in item.Value)
                {
                    Console.WriteLine($"({item.Key}) {kur.Key} <-> {kur.Value}");
                }
            }
        }
    }
}
