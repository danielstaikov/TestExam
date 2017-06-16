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

            // string s = "ABCDEFGH";
            // Console.WriteLine(s);
            //
            // s = s.Remove(3, 2).Insert(3, "ZX");
            //
            // Console.WriteLine(s);

            string s = "abc---def";

            Console.WriteLine("Index: 012345678");
            Console.WriteLine("1)     {0}", s);
            Console.WriteLine("2)     {0}", s.Remove(3));
            Console.WriteLine("3)     {0}", s.Remove(3, 2).Insert(3, "ZX"));


        }
    }
}