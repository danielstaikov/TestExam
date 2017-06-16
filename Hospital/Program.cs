using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int peroid = int.Parse(Console.ReadLine());
            
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int treatedTotal = 0;
            int untreatedTotal = 0;
            int index = 0;

            for (int i = 0; i < ((peroid / 2)+1); i++)
            {
                
                int input = int.Parse(Console.ReadLine());
                
                index += 1;
                if (input >= doctors)
                {
                    treatedPatients = doctors;
                }
                else
                {
                    treatedPatients = input;
                }
                untreatedPatients = input - treatedPatients;
                treatedTotal += treatedPatients;
                untreatedTotal += untreatedPatients;
                if (index >= peroid)
                {
                    break;
                }
                input = int.Parse(Console.ReadLine());
                
                index += 1;
                if (input >= doctors)
                {
                    treatedPatients = doctors;

                }
                else
                {
                    treatedPatients = input;
                }
                untreatedPatients = input - treatedPatients;
                treatedTotal += treatedPatients;
                untreatedTotal += untreatedPatients;

                if (index == peroid)
                {
                    break;
                }

                if (treatedPatients< untreatedPatients)
                {
                    doctors += 1;
                }


            }


            Console.WriteLine($"Treated patients: {treatedTotal}.");
            Console.WriteLine($"Untreated patients: {Math.Abs(untreatedTotal)}.");
        }
    }
}
