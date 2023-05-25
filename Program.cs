using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRainEffect
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "AaB@#$%^&bCcDd0123456789EeFfGgHhIiJjKk@#$%^&LlMmNnOoPpQqRr0123456789SsTtU@#$%^&uVvWwXxYyZz0123456789@#$%^&";

            Random rand = new Random();
            Console.Write("Press ENTER to start...");
            Console.ReadKey();

            for (int i = 0; i < 5000; i++)
            {
                string ss = new string(Enumerable.Repeat(chars, 10).Select(s => s[rand.Next(s.Length)]).ToArray());

                for (int j = 1; j <= 7; j++)
                {
                    for (int s = 1; s <= 8; s++)
                    {
                        if (rand.Next(10) > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }

                        int n = rand.Next(2);
                        Console.Write(n);
                        
                    }
                    if (j != 7)
                    {
                        Console.Write("    ");
                        //Console.Write("" + ss.Substring(0, 5));
                    }
                }

            }
            Console.ResetColor();
            Console.ReadKey();


        }
    }
}
