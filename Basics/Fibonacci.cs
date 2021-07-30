using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int primero = 0;
            int segundo = 1;
            int siguiente;

            Console.WriteLine("Ingrese el valor n hasta donde va la sucesión");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if(i <= 1)
                {
                    siguiente = i;
                }

                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                }

                Console.WriteLine(siguiente);
            }

            Console.Read();
        }
    }
    
}
