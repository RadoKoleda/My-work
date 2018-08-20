using System;

namespace Programing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double priseForPage = double.Parse(Console.ReadLine());
            double priseForCover = double.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());
            double priseForDisainer = double.Parse(Console.ReadLine());
            double teamPrise = double.Parse(Console.ReadLine());

            double priseForBook = (priseForPage * 899) + (priseForCover * 2);
            double daDiscount = discount / 100;
            double daREALpRISE = priseForBook - (priseForBook * daDiscount);
            double Disainer = daREALpRISE + priseForDisainer;
            double teamDiscount = teamPrise / 100;
            double prise = Disainer - (Disainer * teamDiscount);
            Console.WriteLine($"Avtonom should pay {prise:f2} BGN.");
        }
    }
}
