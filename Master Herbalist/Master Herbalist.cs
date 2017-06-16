using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            // daily expenses [1...1000]
            //input line [3...100]
            // “{hours}[1…20]  {path}[1…20] {price}[1…1000]” 
            //“Season Over”
            int dailyExpenses = int.Parse(Console.ReadLine());
            string inputLine = "";
            int totalMoney = 0;
            int dayCount = 0;
            int price1 = 0;

            while (true)

            {
                inputLine = Console.ReadLine();
                if (inputLine == "Season Over")
                {
                    break;
                }
                string[] type = inputLine.Split(' '); // три съставни час, път и цена
                string hour = type[0].ToString();
                int hour1= int.Parse(hour); //времето като дабъл
                int h = 0;
                string path = type[1];// пътя като стринг
                string price = type[2].ToString();
                price1 = int.Parse(price); //цената като double
                int lenght = path.Length;
                int multipleString =  hour1 / lenght;

                for (int i = 0; i < hour1; i++)
                {

                    if (hour1>path.Length)
                    {
                        for (int j = 0; j < multipleString; j++)
                        {
                            path=path+path;
                        }
                        
                    }
                    string path1 = path[i].ToString();
                    switch (path1)
                    {
                        case "H":
                            h++;
                            break;
                    }

                }
                dayCount++;
                    int dayMoney = price1 * h;
                    totalMoney = totalMoney + dayMoney;

            }

                double averageMoney = (double) totalMoney / dayCount;

            if (averageMoney>= dailyExpenses)
            {
                double extraMoney = averageMoney - dailyExpenses;
                Console.WriteLine($"Times are good. Extra money per day: {extraMoney:f2}.");
            }
            else
            {
                double neededMoney = (dailyExpenses - averageMoney)* dayCount;
                Console.WriteLine($"We are in the red. Money needed: {neededMoney}.");
            }

        }
    }
}
