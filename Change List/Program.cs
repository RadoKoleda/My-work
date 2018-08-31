using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] comand = Console.ReadLine().Split().ToArray();

            while (comand[0] != "Odd" && comand[0] != "Even")
            {
                if (comand[0] == "Delete")
                {
                    input.RemoveAll(x => x == int.Parse(comand[1]));
                }
                else if (comand[0] == "Insert")
                {
                    input.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
                comand = Console.ReadLine().Split().ToArray();
            }

            if (comand[0] == "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if(input[i] % 2 == 1)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if(input[i] % 2 == 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
            }
        }
    }
}
