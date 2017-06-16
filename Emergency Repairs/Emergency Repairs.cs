using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            int repairKits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());
            string binary = Convert.ToString((long)wall, 2).PadLeft(64, '0');
            
            string cases= "";
            string newS = "";
            for (int i = 1; i <= attacks; i++)
            {
                int target = int.Parse(Console.ReadLine());
                int index = 63 - target;
                cases = binary[index].ToString();
                bool check = (cases == "1");

                if (check)
                {

                    newS = binary.Remove(index, 1).Insert(index, "0");
                }

            }
            for (int j = 0; j < 64; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            Console.WriteLine(binary);
            Console.WriteLine(newS);
        }
    }
}
