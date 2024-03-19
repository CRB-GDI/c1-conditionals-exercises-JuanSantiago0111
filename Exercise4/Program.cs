using System;
using System.Runtime.InteropServices;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = 3;
            string weather = "bad";
              
            if (people <= 11 && weather == "nice")
            {
                // this code will run 
                Console.WriteLine("SaladMart");
            }
            else  
            {
                // if the above condition isn't met , this code will run 
                Console.WriteLine("Soup N Sandwich");
            }








        }
        
    }
}
