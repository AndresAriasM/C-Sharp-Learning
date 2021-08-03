using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number;
            number = new int [4, 4];

            for (int line = 0; line < 4; line++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Console.WriteLine("Enter a random number");
                    number[line, column] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int line = 0; line < 4; line++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Console.WriteLine(" " + number[line, column]);
                }

                Console.WriteLine(); 
            }

            Console.Read();
        }
    }
}
