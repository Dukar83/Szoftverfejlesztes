using System;
using System.Runtime.InteropServices;

namespace parosParatlaNnulla
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21. bekér a felhasználótól egy számot, majd kiírja az adott számról, hogy páros, páratlan, vagy nulla.
            Console.WriteLine("Adj be egy számot, megállapitom hogy páros páratlan vagy nulla");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)           {                Console.WriteLine("Nulla");            } 
            else if (a%2 == 0)    {                Console.WriteLine("Páros");            }
            else                  {                Console.WriteLine("Páratlan");         }

            Console.ReadKey();
        }
        }
}

