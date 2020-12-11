using System;
using System.Collections.Generic;

namespace tesztelős
{
    class Emlősök
    {
        public void Evés()
        {
            Console.WriteLine("Etetés");
        }
    }

    class Kutyák : Emlősök
    {

    }

    class Labrador : Kutyák
    {

    }
  
       
     class Program
    {    
        static void Main(string[] args)
        {
            Labrador l = new Labrador();
            l.Evés();


            Console.ReadKey();
        }
    }
}
