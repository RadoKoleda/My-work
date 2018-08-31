using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sum = new List<int>();
            int removedEle = 0;

            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                for (int i = 0; i < input.Count; i++)
                {
                    if (i == index)
                    {
                        removedEle = input[i];
                        input.RemoveAt(i);
                    }
                    else if (i < index)
                    {
                        if (input[i] <= input[index])
                        {
                            input[i] += input[index];
                        }
                        else
                        {
                            input[i] -= input[index];
                        }
                    }
                    else if (i > index)
                    {
                        if(i <= removedEle)
                        {
                            input[i - 1] += removedEle;
                        }
                        else
                        {
                            input[i - 1] -= removedEle;
                        }
                    }
                }
            }
        }
    }
}
