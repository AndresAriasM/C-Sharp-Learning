using System;

namespace Rubik_Methods
{
    class Program
    { 
 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rubik Solver, enter your average time (seconds) in the 3x3 cube. Remember it must be a whole number");
            Console.WriteLine("This program recommends some 3x3 methods based on your current times for you to improve your average.");
            Console.WriteLine("If you don't know how to solve the Rubik's cube, you should try the beginner method.");

            string RubikTime = Console.ReadLine();
            int Times = int.Parse(RubikTime); 
            string Method;

            Method = Times > 30 ? "You should try CFOP reduced or ROUX" : Times >= 20 ? "You should try CFOP" : Times >= 10 ? "You should improve your Look-Ahead" : Times > 0 ? "you should try ZBLL with CFOP" : "The entered value is invalid";

            Console.WriteLine(Method);
            Console.WriteLine("You can find tutorials on YouTube and forums, good luck!");
            Console.Read();
                
        }
    }
}
