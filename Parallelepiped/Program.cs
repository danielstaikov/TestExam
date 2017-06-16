using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int high = 4 * n + 4;
            for (int i = 0; i < high / 2; i++)// половинка фигура
            {
                if (i == 0)
                {
                    Console.Write("+");
                    Console.Write(new string('~', n - 2));
                    Console.Write("+");
                    Console.WriteLine(new string('.', (3 * n + 1) - n));
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string('.', i - 1));
                    Console.Write("\\");
                    Console.Write(new string('~', n - 2));
                    Console.Write("\\");
                    Console.WriteLine(new string('.', (3 * n + 1) - n - i));
                }
            }

            for (int i = 0; i < high / 2; i++)// втора половинка фигура
            {
                if (i == (high / 2)-1)
                {
                    Console.Write(new string('.', (3 * n + 1) - n));
                    Console.Write("+");
                    Console.Write(new string('~', n - 2));
                    Console.WriteLine("+");

                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write("\\");
                    Console.Write(new string('.', (3 * n  - n - i)));
                    Console.Write("|");
                    Console.Write(new string('~', n - 2));
                    Console.WriteLine("|");

                }
            }
        }
    }
}
