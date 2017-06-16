using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n =0;
            uint m = 0;
            try
            {
                n = uint.Parse(Console.ReadLine());
                m = uint.Parse(Console.ReadLine());

            }

            catch
            {
                Console.WriteLine("invalid number");
            }
            

            int controlNumber = int.Parse(Console.ReadLine());
            uint sum = 0;
            int moves = 0;
            
                for (uint i = 1; i <= n; i++)
                {
                    for (uint j = m; j >= 1; j--)
                    {
                        sum = i * 2 + j * 3 + sum;
                        moves++;
                        if (sum >= controlNumber)
                        {
                            break;
                        }
                    }

                }

                if (sum < controlNumber)
                {
                    Console.WriteLine($"{moves} moves");
                }
                else
                {
                    Console.WriteLine($"{moves} moves");
                    Console.WriteLine($"Score: {sum} >= {controlNumber}");
                }

            }
        }
    }



