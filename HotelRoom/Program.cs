using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //месецът – May, June, July, August, September или October
            //броят на нощувките – цяло число в интервала[0... 200]
            string month = Console.ReadLine();
            int accommodations = int.Parse(Console.ReadLine());
            double studioDayPrice = 0;
            double apartmantDayPrice = 0;
            double studioDiscount = 1;
            double apartmantDiscount = 1;


            if (month.ToLower() == "may"|| month.ToLower()== "october") //Студио – 50 лв./нощувка; Апартамент – 65 лв./нощувка
            {
                studioDayPrice = 50;
                apartmantDayPrice = 65;
                if (accommodations>14 )
                {
                    studioDiscount = 0.7;
                    apartmantDiscount = 0.9;
                }
                else if (accommodations > 7)
                {
                    studioDiscount = 0.95;
                }
                else
                {
                    //sorry no bonus!
                }
            }
            else if (month.ToLower() == "june" || month.ToLower() == "september") //Студио – 75.20 лв./нощувка; Апартамент – 68.70 лв./нощувка
            {
                studioDayPrice = 75.20;
                apartmantDayPrice = 68.70;
                if (accommodations > 14)
                {
                    studioDiscount = 0.8;
                    apartmantDiscount = 0.9;
                }
                else 
                {
                    // no bonus
                }
                
            }
            else // Студио – 76 лв./нощувка; Апартамент – 77 лв./нощувка
            {
                studioDayPrice = 76;
                apartmantDayPrice = 77;
                if (accommodations > 14)
                {
                    apartmantDiscount = 0.9;
                }
                else
                {
                    // no bonus
                }

            }
            double studioPrice = studioDayPrice * accommodations * studioDiscount;
            double apartmantPrice = apartmantDayPrice * accommodations * apartmantDiscount;



            Console.WriteLine($"Apartment: {apartmantPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
