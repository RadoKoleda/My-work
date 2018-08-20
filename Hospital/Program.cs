using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= n; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                

                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }

                if (patients > doctors)
                {
                    int diff = patients - doctors;
                    untreatedPatients = untreatedPatients + diff;
                    treatedPatients = treatedPatients + doctors;
                }
                else
                {
                    treatedPatients = treatedPatients + patients;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
