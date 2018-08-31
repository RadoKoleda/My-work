using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Problem_Class_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            Dictionary<string, int> participant = new Dictionary<string, int>();
            List<string> language = new List<string>();

            while (input[0] != "exam finished")
            {
                if (input[1] == "banned")
                {
                    participant.Remove(input[0]);
                }
                else if (participant.ContainsKey(input[0]))
                {
                    if (participant[input[0]] < int.Parse(input[2]))
                    {
                        participant[input[0]] = int.Parse(input[2]);
                    }
                    language.Add(input[1]);
                }
                else
                {
                    participant.Add(input[0], int.Parse(input[2]));
                    language.Add(input[1]);
                }
                input = Console.ReadLine().Split('-').ToArray();
            }

            Console.WriteLine("Results:");
            foreach (var item in participant.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Dictionary<string, int> languageCount = new Dictionary<string, int>();
            for (int i = 0; i < language.Count; i++)
            {
               if (languageCount.ContainsKey(language[i]))
               {
                    languageCount[language[i]]++;
               }
               else
               {
                    languageCount.Add(language[i], 1);
               }
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
