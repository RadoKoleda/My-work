using System;
using System.Text.RegularExpressions;

namespace Exam_Problem_3_SoftUniBar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"%([A-Z]{1}[a-z]*)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.\d]*(\d+(\.|)*\d+)\$";
            Regex regex = new Regex(patern);
            string input = Console.ReadLine();
            double totalIncome = 0.0;

            while (input != "end of shift")
            {
                int count = 0;
                double price = 0.0;
                Match match = regex.Match(input);
                if (regex.IsMatch(input))
                {
                    count = int.Parse(match.Groups[3].ToString());
                    price = double.Parse(match.Groups[4].ToString());
                    double sum = count * price;
                    totalIncome += sum;
                    Console.WriteLine($"{match.Groups[1]}: {match.Groups[2]} - {sum:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
