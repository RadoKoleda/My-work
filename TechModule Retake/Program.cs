using System;
using System.Linq;

namespace TechModule_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOne = Console.ReadLine().Split().ToArray();
            string[] lineTwo = Console.ReadLine().Split().ToArray();

            int lenth = Math.Min(lineOne.Length, lineTwo.Length);
            int counter = 0;
            int counterLeft = 0;

            for (int i = 0; i < lenth; i++)
            {
                if (lineOne[i] == lineTwo[i])
                {
                    counter++;
                }
            }
            for (int i = 0; i < lenth; i++)
            {
                if (lineOne[(lineOne.Length - 1) - i] == lineTwo[(lineTwo.Length - 1) - i])
                {
                    counterLeft++;
                }
            }
            if (counter > counterLeft)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(counterLeft);
            }
        }
    }
}
