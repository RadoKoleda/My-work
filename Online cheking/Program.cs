using System;

namespace Online_cheking
{
    class Program
    {
        static void Main(string[] args)
        {
            string earlySign = Console.ReadLine();
            int studentsEarly = int.Parse(Console.ReadLine());
            string ontimeSign = Console.ReadLine();
            int studentsOntime = int.Parse(Console.ReadLine());
            string lateSign = Console.ReadLine();
            int studentsLate = int.Parse(Console.ReadLine());

            int online = 0;
            int onsite = 0;

            if(earlySign == "online")
            {
                online += studentsEarly;
            }
            else if (ontimeSign == "onsite")
            {
                if (onsite > 600)
                {
                    online += studentsEarly;
                }
                else if (onsite <= 600 && (onsite + studentsEarly) > 600)
                {
                    int diff = 600 - onsite;
                    onsite += diff;
                    online += studentsEarly - diff;
                }
                else
                {
                    onsite += studentsEarly;
                }
            }
            if (ontimeSign == "online")
            {
                online += studentsOntime;
            }
            else if (ontimeSign == "onsite")
            {
                if (onsite > 600)
                {
                    online += studentsOntime;
                }
                else if (onsite <= 600 && (onsite + studentsOntime) > 600)
                {
                    int diff = 600 - onsite;
                    onsite += diff;
                    online += studentsOntime - diff;
                }
                else
                {
                    onsite += studentsOntime;
                }
            }
            if (lateSign == "online")
            {
                online += studentsLate;
            }
            else if (lateSign == "onsite")
            {
                if (onsite > 600)
                {
                    online += studentsOntime;
                }
                else if (onsite <= 600 && (onsite + studentsLate) > 600)
                {
                    int diff = 600 - onsite;
                    onsite += diff;
                    online += studentsLate - diff;
                }
                else
                {
                    onsite += studentsLate;
                }
            }
            int total = onsite + online;
            Console.WriteLine($"Online students: {online}");
            Console.WriteLine($"Onsite students: {onsite}");
            Console.WriteLine($"Total students: {total}");
        }
    }
}
