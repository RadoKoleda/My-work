using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int well = number;

            int thirdNum = well % 10;
            int wellOne = well / 10;
            int secondNum = wellOne % 10;
            int wellTwo = wellOne / 10;
            int firstNum = wellTwo;

            int row = firstNum + secondNum;
            int col = firstNum + thirdNum;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    thirdNum = number % 10;
                    wellOne = number / 10;
                    secondNum = wellOne % 10;
                    wellTwo = wellOne / 10;
                    firstNum = wellTwo;
                    if (well % 5 == 0)
                    {
                        well = well - firstNum;
                    }
                    else if (well % 3 == 0)
                    {
                        well = well - secondNum;
                    }
                    else
                    {
                        well = well + thirdNum;
                    }
                    Console.Write(well + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
