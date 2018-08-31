using System;

namespace Exam_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploye = int.Parse(Console.ReadLine());
            int secondEmploye = int.Parse(Console.ReadLine());
            int thirdEmploye = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int hour = 0;
            int capacityPerHour = firstEmploye + secondEmploye + thirdEmploye;
            while (students > 0)
            {
                if (students < capacityPerHour)
                {
                    students -= students;
                    hour++;
                }
                else
                {
                    students -= capacityPerHour;
                    hour++;
                }
            }
            double restHour = Math.Ceiling(hour / 3.0);
            int neededHour = hour + (int)restHour;
            Console.WriteLine($"Time needed: {neededHour}h.");
        }
    }
}
