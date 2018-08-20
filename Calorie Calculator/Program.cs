using System;

namespace Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            string activity = Console.ReadLine();

            double HEIGHT = height * 100.0;
            double BNM = 0;
            if (gender == "m")
            {
                if(activity == "sedentary")
                {
                    BNM = 66 + (13.7 * weight) + (5 * HEIGHT) - (6.8 * years);
                    int final = (int)Math.Ceiling(BNM * 1.2);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if(activity == "lightly active")
                {
                    BNM = 66 + (13.7 * weight) + (5 * HEIGHT) - (6.8 * years);
                    int final = (int)Math.Ceiling(BNM * 1.375);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if(activity == "moderately active")
                {
                    BNM = 66 + (13.7 * weight) + (5 * HEIGHT) - (6.8 * years);
                    int final = (int)Math.Ceiling(BNM * 1.55);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if (activity == "very active")
                {
                    BNM = 66 + (13.7 * weight) + (5 * HEIGHT) - (6.8 * years);
                    int final = (int)Math.Ceiling(BNM * 1.725);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
            }
            else if (gender == "f")
            {
                if (activity == "sedentary")
                {
                    BNM = 655 + (9.6 * weight) + (1.8 * HEIGHT) - (4.7 * years);
                    int final = (int)Math.Ceiling(BNM * 1.2);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if (activity == "lightly active")
                {
                    BNM = 655 + (9.6 * weight) + (1.8 * HEIGHT) - (4.7 * years);
                    int final = (int)Math.Ceiling(BNM * 1.375);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if (activity == "moderately active")
                {
                    BNM = 655 + (9.6 * weight) + (1.8 * HEIGHT) - (4.7 * years);
                    int final = (int)Math.Ceiling(BNM * 1.55);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
                else if (activity == "very active")
                {
                    BNM = 655 + (9.6 * weight) + (1.8 * HEIGHT) - (4.7 * years);
                    int final = (int)Math.Ceiling(BNM * 1.725);
                    Console.WriteLine($"To maintain your current weight you will need {final} calories per day.");
                }
            }
        }
    }
}
