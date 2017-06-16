using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double run = double.Parse(Console.ReadLine());

            double coef = 0;
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (run > 10000)
                    {
                        coef = 1.45;
                    }
                    else if (run > 5000 && run<=10000)
                    {
                        coef = 0.95;
                    }
                    else
                    {
                        coef = 0.75;
                    }
                    break;
                case "Summer":
                    if (run > 10000)
                    {
                        coef = 1.45;
                    }
                    else if (run > 5000 && run <= 10000)
                    {
                        coef = 1.10;
                    }
                    else
                    {
                        coef = 0.90;
                    }
                    break;
                case "Winter":
                    if (run > 10000)
                    {
                        coef = 1.45;
                    }
                    else if (run > 5000 && run <= 10000)
                    {
                        coef = 1.25;
                    }
                    else
                    {
                        coef = 1.05;
                    }
                    break;
            }
            double profit = run* coef*4*0.90;
            Console.WriteLine($"{profit:f2}");
        }
    }
}
