using System;

namespace Code_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine().ToUpper());
            char c = char.Parse(Console.ReadLine().ToLower());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            long N = long.Parse(Console.ReadLine());

            long currentTurn = 1;
            bool isFound = false;

            for (int numA = 1; numA <= a; numA++)
            {
                for (char numB = 'A'; numB <= b; numB++)
                {
                    for (char numC = 'a'; numC <= c; numC++)
                    {
                        for (int numD = 1; numD <= d; numD++)
                        {
                            for (int numE = 1; numE <= e; numE++)
                            {
                                for (int numF = 1; numF <= f; numF++)
                                {
                                    if (currentTurn == N)
                                    {
                                        Console.WriteLine($"{numA}{numB}{numC}{numD}{numE}{numF}");
                                        isFound = true;
                                        return;
                                    }
                                    currentTurn += 1;
                                }
                            }
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No password on this position");
            }
        }
    }
}
