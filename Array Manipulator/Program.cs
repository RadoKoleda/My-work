using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            while(command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int[] newInput = new int[input.Length + 1];
                    for (int i = 0; i < newInput.Length; i++)
                    {
                        if (i == int.Parse(command[1]))
                        {
                            newInput[i] = int.Parse(command[2]);
                        }
                        else
                        {
                            if (i <= int.Parse(command[1]))
                            {
                                newInput[i] = input[i];
                            }
                            else
                            {
                                newInput[i] = input[i - 1];
                            }
                        }
                    }
                    input = newInput;
                }
                else if (command[0] == "addMany")
                {
                    int[] newInput = new int[input.Length + (command.Length - 2)];
                    for (int i = 0; i < newInput.Length; i++)
                    {
                        if (i == int.Parse(command[1]))
                        {
                            for (int j = 2; j < command.Length; j++)
                            {
                                newInput[i] = int.Parse(command[j]);
                                if (j == command.Length - 1)
                                {

                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            if (i <= int.Parse(command[1]))
                            {
                                newInput[i] = input[i];
                            }
                            else
                            {
                                newInput[i] = input[i - (command.Length - 2)];
                            }
                        }
                    }
                    input = newInput;
                }
                else if (command[0] == "contains")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == int.Parse(command[1]))
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else if (i == input.Length - 1)
                        {
                            Console.WriteLine("-1");
                        }
                    }
                }
                else if (command[0] == "sumPairs")
                {
                    int count = 0;
                    int lenth = (int)Math.Round(input.Length / 2.0);
                    int[] DAFACK = new int[lenth];
                    for (int i = 0; i < input.Length; i+=2)
                    {
                        if (i == input.Length - 1)
                        {
                            DAFACK[count] = input[i];
                            count++;
                        }
                        else
                        {
                            DAFACK[count] = input[i] + input[i + 1];
                            count++;
                        }
                    }
                    input = DAFACK;
                }
                else if (command[0] == "shift")
                {
                    List<int> newList = new List<int>();
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        newList.Insert(0, input.Length - i);
                    }
                    if (int.Parse(command[1]) < input.Length)
                    {
                        for (int i = newList.Count - 1; i < input.Length; i++)
                        {
                            newList.Add(input[i]);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine("[" + string.Join(',', input) + "]");
        }
    }
}
