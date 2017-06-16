using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaOfHouse = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double sqMeterForPack = double.Parse(Console.ReadLine());
            double priceStirofoam = double.Parse(Console.ReadLine());
            double areaForFoaming = (areaOfHouse - windows * 2.40)*1.10;
            double stiroPack = Math.Ceiling(areaForFoaming / sqMeterForPack);
            double neededMoney = stiroPack * priceStirofoam;
            if (neededMoney> budget)
            {
                double moreMoney = neededMoney - budget;
                Console.WriteLine($"Need more: {moreMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Spent: {neededMoney:f2}");
                double leftMoney = budget - neededMoney;
                Console.WriteLine($"Left: {leftMoney:f2}");
            }

        }
    }
}
