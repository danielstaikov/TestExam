using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounts = int.Parse(Console.ReadLine());
            double sumElectrisity = 0;
            double sumOther = 0;
            for (int i = 0; i < mounts; i++)
            {
                double electrisityBill = double.Parse(Console.ReadLine());
                sumElectrisity += electrisityBill;
                double otherBills = (electrisityBill + 35) * 1.2;
                sumOther += otherBills;
            }
            double sumWater = mounts*20;
            double sumInternet = mounts * 15;
            double average = (sumElectrisity + sumWater + sumInternet + sumOther) / mounts;

            Console.WriteLine($"Electricity: {sumElectrisity:f2} lv");
            Console.WriteLine($"Water: {sumWater:f2} lv");
            Console.WriteLine($"Internet: {sumInternet:f2} lv");
            Console.WriteLine($"Other: {sumOther:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");


       }
    }
}
