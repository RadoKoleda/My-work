using System;

namespace Cat_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            string foodTaken = Console.ReadLine();
            double foodKG = double.Parse(foodTaken) * 1000;
            foodTaken = Console.ReadLine();
            double foodEaten = 0;

            while (foodTaken != "Adopted")
            {
                foodEaten += double.Parse(foodTaken);
                foodTaken = Console.ReadLine();
            }

            if (foodEaten > foodKG)
            {
                double diff = Math.Abs(foodEaten - foodKG);
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
            else
            {
                double diff = foodKG - foodEaten;
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
        }
    }
}
