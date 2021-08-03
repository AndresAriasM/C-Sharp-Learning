using System;
using System.Text.RegularExpressions;

namespace PalindromosV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una palabra aleatoria");
            Console.WriteLine("");
            Console.WriteLine("El programa le mostrara si se trata de una palabra palindroma o capicúa");

            string cadena = Console.ReadLine();
            string inverso = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                inverso += cadena[i];
            }

            if (cadena == inverso)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("La palabra " + cadena + " es palindroma");
                }
                catch
                {
                    Convert.ToInt32(cadena);
                    Console.WriteLine("");
                    Console.WriteLine("La palabra " + cadena + " es una capicúa");
                }

            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("La palabra " + cadena + " no pertenece al grupo seleccionado");
            }

            Console.WriteLine("Fin del programa");

        }
    }
}
