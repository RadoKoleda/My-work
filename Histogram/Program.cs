using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;
            double countP4 = 0;
            double countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    countP1++;
                }
                else if (number >= 200 && number < 400)
                {
                    countP2++;
                }
                else if (number >= 400 &&  number < 600)
                {
                    countP3++;
                }
                else if (number >= 600 && number < 800)
                {
                    countP4++;
                }
                else if (number >= 800)
                {
                    countP5++;
                }
            }
            p1 = (countP1 / n) * 100;
            p2 = (countP2 / n) * 100;
            p3 = (countP3 / n) * 100;
            p4 = (countP4 / n) * 100;
            p5 = (countP5 / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
