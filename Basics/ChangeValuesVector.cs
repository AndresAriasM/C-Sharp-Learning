using System;

namespace ChangeValuesVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector = new int[5];

            for (int vector1 = 0; vector1 < 5; vector1++)
            {
                Console.WriteLine("Enter a random number");
                vector[vector1] = Convert.ToInt32(Console.ReadLine());
            }
           
            foreach (int graphic in vector)
            {
                Console.Write(graphic + " | ");
            }
          
            Console.WriteLine("Now enter one of the numbers to know their position");
            int index = Convert.ToInt32(Console.ReadLine());
            int mystery = Array.IndexOf(vector, index);

            Console.WriteLine("The position of " + index + " is " + mystery);
            Console.WriteLine("");

            Console.WriteLine("If you want to replace some value press 1, otherwise press 2 to finish the program");
            int option = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (option == 1)
                {
                    Console.WriteLine("Enter the position you want to replace");
                    int position = Convert.ToInt32(Console.ReadLine());

                    do
                    {                    
                        if (position >= 0 && position < vector.Length)
                        {
                            Console.WriteLine("Enter the new value for this position");
                            int newvalue = Convert.ToInt32(Console.ReadLine());
                            vector[position] = newvalue;
                            Console.WriteLine("The value has been changed");
                        }

                        else
                        {
                            Console.WriteLine("This position does not exist");
                        }

                    } while (position < 0 && position > vector.Length);
                }

                else if (option == 2)
                {
                    Console.WriteLine("End of the program");
                    Environment.Exit(1);
                }

                else
                {
                    Console.WriteLine("You entered a wrong value");
                }

            } while (option != 1 && option != 2);

            Console.WriteLine("This is the new vector:");

            foreach (int graphic in vector)
            {
                Console.Write(graphic + " | ");
            }

            Console.WriteLine("End of the program");

            Console.Read();
        }
    }
}
