using System;

namespace pluszminusz
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat: 1. bekér két egész számot (𝑎,𝑏), majd kiszámolja a két szám összegét, különbségét.
            Console.WriteLine("Hello, adj be két számot!");
            
            int a, b, össz, kivon;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
            össz = a + b;
            Console.WriteLine("\nA két szám összege:{0}", össz);

            if (a > b)
            {
                kivon = a - b;
            }
            else kivon = b - a;
            Console.WriteLine("\nA két szám különbsége:{0}", kivon);
        }
    }
}
