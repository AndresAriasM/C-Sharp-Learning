using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace Null_Coalescing_Operator
{
    class Program
    {
        public class Car
        {
            public string Model { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Do you have a car?");
            Console.WriteLine("If you have enter you car brand or model");
            Console.WriteLine("If you not, please press enter");

            var customer = new Car
            {
                Model = Console.ReadLine()
            };

            if (customer.Model == "")
            {
                customer.Model = null;
            }

            if (customer.Model != null)
            {
                Console.WriteLine("Nice! We can offer you a special wash for your ");
            }

            string result = customer.Model ?? "We have a special discount for you on many car models";

            Console.WriteLine(result);

        }
    }
}
