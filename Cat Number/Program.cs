using System;

namespace Cat_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                string lastName = Console.ReadLine();
                int birthfay = int.Parse(Console.ReadLine());
                int asciiOne = name[0];
                int asciiTwo = lastName[0];
                Console.WriteLine($"{birthfay}{asciiOne}{asciiTwo}{i}");
            }
        }
    }
}
