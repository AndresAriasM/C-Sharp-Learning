using System;

namespace Matrix_Diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            matrix = new int[10, 10];

            for (int line = 0; line < 10; line++)
            {
                for (int column = 0; column < 10; column++)
                {                 

                    if (line == column) // Diagonal
                    {
                        matrix[line, column] = 1;
                    }

                    else if (line + column == 9) // Diagonal Secundaria
                    {
                        matrix[line, column] = 1;
                    }

                    else
                    {
                        matrix[line, column] = 0;
                    }
                }
            }

            Console.Clear();

            for (int line = 0; line < 10; line++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write(" " + matrix[line, column]);
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
