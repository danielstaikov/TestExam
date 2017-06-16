using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double possibleCake = Math.Floor(f / c);
            double trueflePrice = t * p;
            double cakePrice = (trueflePrice / n) * 1.25d;
            double totalFloor = n * c;
            double neededFloor = totalFloor -f;

            if (possibleCake>=n)
            {
                Console.WriteLine($"All products available, price of a cake: {cakePrice:f2}");
            }
            else
            {
                Console.WriteLine($"Can make only {possibleCake} cakes, need {neededFloor:f2} kg more flour");
            }
            
        }
    }
}
