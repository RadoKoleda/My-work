using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> player = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "Season end")
            {
                /*player.Add(input[0], new Dictionary<string, int>());
                player[input[0]].Add(input[1], int.Parse(input[2]));
                input = Console.ReadLine().Split(" -> ").ToArray();
                */
                string[] tokens = input.Split(" -> ").ToArray();
                if (tokens.Length == 3)
                {

                    if (player.ContainsKey(tokens[0]) == false)
                    {
                        player.Add(tokens[0], new Dictionary<string, int>());
                        player[tokens[0]].Add(tokens[1], int.Parse(tokens[2]));
                    }
                    else if (player[tokens[0]].ContainsKey(tokens[1]) == false)
                    {
                        player[tokens[0]].Add(tokens[1], int.Parse(tokens[2]));
                    }
                    else if (player[tokens[0]][tokens[1]] < int.Parse(tokens[2]))
                    {
                        player[tokens[0]][tokens[1]] = int.Parse(tokens[2]);
                    }
                }
                else if (tokens.Length == 1)
                {
                    tokens = input.Split(" vs ").ToArray();
                    if (player.ContainsKey(tokens[0]) && player.ContainsKey(tokens[1]))
                    {
                        /*if (player[tokens[0].Keys] == player[tokens[1]].Keys)
                        {
                            Console.WriteLine("HUI");
                        }*/
                        /*for (int i = 0; i < player.Count; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                if (player[tokens[0]].ElementAt(i).Equals(player[tokens[1]].ElementAt(j))
                                
                            }
                        }*/
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
