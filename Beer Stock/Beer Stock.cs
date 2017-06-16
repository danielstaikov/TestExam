using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {

              string input = "";
              double result = 0;
              double kol = 0;
              double waste = 0;
                int resevedBeers = int.Parse(Console.ReadLine());

            while (true)

                {
                    input = Console.ReadLine();
                    if (input == "Exam Over")
                    {
                        break;
                    }
                    string[] type = input.Split(' ');
                    string number = type[0].ToString();
                    kol = double.Parse(number);
                    string cases = type[1];

                    switch (cases)
                    {
                        case "cases":
                            kol = kol * 24;
                            break;
                        case "sixpacks":
                            kol = kol * 6;
                            break;
                    }

                    result = result + kol;

                    
                }
            waste = result - (int)(result / 100);

            if (resevedBeers <= waste) // стигат
                {
                double diff = waste - resevedBeers;
                double cases1 = Math.Floor(diff / 24);
                double sixpacks1 = Math.Floor((diff - (cases1 * 24)) / 6);
                double beers1 = Math.Round(diff - (cases1 * 24) - (sixpacks1 * 6));
                Console.WriteLine($"Cheers! Beer left: {cases1:f0} cases, {sixpacks1} sixpacks and {beers1} beers.");

                }
                else // не стигат
                {
                double diff = resevedBeers - waste;
                double cases1 = Math.Floor(diff / 24);
                double sixpacks1 = Math.Floor((diff - (cases1 * 24)) / 6);
                double beers1 = Math.Round(diff - (cases1 * 24) - (sixpacks1 * 6));
                Console.WriteLine($"Not enough beer. Beer needed: {cases1:f0} cases, {sixpacks1} sixpacks and {beers1} beers.");

            }
            }

        }
    }