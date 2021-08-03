using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number;
            number = new int[5];

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[3] = 4;
            number[4] = 5;

            foreach (int element in number)
            {
                Console.WriteLine(element);  
            }

            Console.Read();
        }
    }
}
