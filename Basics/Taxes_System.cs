using System;

namespace Taxes_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to goverment taxes system");

            Console.WriteLine("How many cars do you have?");

            string cars = Console.ReadLine();
            int numcars = int.Parse(cars);

            if (numcars == 0)
            {
                Console.WriteLine("You do not pay taxes");
            }
            else if (numcars == 1)
            {
                Console.WriteLine("You must pay " + (numcars * 20) + "$");
            }
            else if (numcars == 2)
            {
                Console.WriteLine("You must pay " + (numcars * 20) + "$");
            }
            else if (numcars > 2)
            {
                Console.WriteLine("You must pay " + (numcars * 20) + "$");
            }
            else
            {
                Console.WriteLine("The entered value is invalid");
            }

            Console.Read();
        }
    }
}
