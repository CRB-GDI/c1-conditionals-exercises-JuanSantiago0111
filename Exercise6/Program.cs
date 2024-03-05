using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = 0;

            if (guests >= 3)
            {
                Console.WriteLine("We play Catan");
            }
            else if (guests >= 1 && guests <= 0)
            {
                Console.WriteLine("We play Innovation");

            }
            else 
            {
                Console.WriteLine("I play solitare");
            }
        }
    }
}
