using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_the_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string line= Console.ReadLine();
            int messgCounter = 0;
            char[] specialChars = new[] { ' ', ',', '?', '!'};
            List<string> messages = new List<string>();

            while (line.ToLower() == "start")
            {
                line = Console.ReadLine();
            }
                while (line.ToLower() != "end")
                {
                    if (!string.IsNullOrEmpty(line) && line.ToLower() != "start")
                    {
                        messgCounter += 1;
                    }

                    //line = Console.ReadLine();
                    char [] reversed = Reverse(line).ToCharArray();

                    for (int i = 0; i < reversed.Length; i++)
                     {
                        if( (reversed[i]>='A' && reversed[i]<='M') || (reversed[i] >= 'a' && reversed[i] <= 'm'))// Letters from A to M and a to m
                          {
                          Console.WriteLine($"{reversed[i]}");
                              int number = reversed[i];
                              number += 13;
                              reversed[i] = (char)number;
                          Console.WriteLine($"{reversed[i]}");
                          }
                        else if ((reversed[i] >= 'N' && reversed[i] <= 'Z') || (reversed[i] >= 'n' && reversed[i] <= 'z'))// letters from N to Z
                             {
                             Console.WriteLine($"{reversed[i]}");
                             int number = reversed[i];
                             number -= 13;
                             reversed[i] = (char)number;
                             Console.WriteLine($"{reversed[i]}");
                             }
                        else if (specialChars.Contains(reversed[i]))
                            {
                             char blabla = reversed[i];
                             switch (blabla)
                             {
                                 case' ':
                                     reversed[i] = '+';
                                     break;
                             }
                            }
                    }


                }

            if (messgCounter > 0)
            {
                Console.WriteLine("....");
            }
            else
            {
                Console.WriteLine("No messages sent.");
                foreach (string message in messages)
                {

                    Console.WriteLine($"{message}");
                }
            }
        }

        private static string Reverse(string line)
        {
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}