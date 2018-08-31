using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int originN = N;
            int poke = 0;

            while (N >= M)
            {
                if (N == originN / 2)
                {
                    N = N / Y;
                }
                else
                {
                    N = N - M;
                    poke++;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(poke);
        }
    }
}
