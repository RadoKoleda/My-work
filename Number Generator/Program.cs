using System;
using System.Linq;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string M = Console.ReadLine();
            string N = Console.ReadLine();
            string L = Console.ReadLine();
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            string daNum = M + N + L;
            int getDaNum = int.Parse(daNum);

            for (int i = getDaNum; i >= 111; i--)
            {
                if (i % 3 == 0)
                {
                    specialNum = specialNum + 5;
                }
                else if (i % 10 == 5)
                {
                    specialNum = specialNum - 2;
                }
                else if (i % 2 == 0)
                {
                    specialNum = specialNum * 2;
                }

                if (specialNum >= controlNum)
                {
                    Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                    return;
                }
            }
            Console.WriteLine($"No! {specialNum} is the last reached special number.");
        }
    }
}
