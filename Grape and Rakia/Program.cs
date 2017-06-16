using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kgForSqmeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());
            double allGrape = area * kgForSqmeter;
            double rakia = (allGrape - waste) * 0.45 / 7.50;
            double moneyRakia = rakia * 9.80;
            double moneyGrape = (allGrape - waste) * 0.55 * 1.50;
            Console.WriteLine($"{moneyRakia:f2}");
            Console.WriteLine($"{moneyGrape:f2}");
        }
    }
}
