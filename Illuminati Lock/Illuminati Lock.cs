using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = n;
            int y = 0;
            int z=0;

            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n));

            for (int i = 1; i < ((n+1)/2); i++)
            {
                
                x = x - 2;
                y = 2;
                z = n - x - y;
                Console.Write(new string('.',x));
                Console.Write(new string('#', y));
                Console.Write(new string('.', z));
                Console.Write("#");
                Console.Write(new string('.', (n-2)));
                Console.Write("#");
                Console.Write(new string('.', z));
                Console.Write(new string('#', y));
                Console.WriteLine(new string('.', x));
            }
            for (int j = ((n + 1) / 2) ; j > 1; j--)
            {
                
                Console.Write(new string('.', x));
                Console.Write(new string('#', y));
                Console.Write(new string('.', z));
                Console.Write("#");
                Console.Write(new string('.', (n - 2)));
                Console.Write("#");
                Console.Write(new string('.', z));
                Console.Write(new string('#', y));
                Console.WriteLine(new string('.', x));
                x = x + 2;
                z = n - x - y;
            }
            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n));
        }
    }
}
