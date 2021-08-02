using System;
using System.Text.RegularExpressions;

namespace #deCaracteresEnString
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese una palabra aleatoria");
            string Entrada = Console.ReadLine();

            Console.WriteLine("Ahora ingrese una letra perteneciente a la palabra que anteriormente ingresasada, el programa te dira cuantas veces esta esa letra en la palabra");
            string caracter = Console.ReadLine();

            int contador = Regex.Matches(Entrada,caracter).Count; // Expresión ligada a (using System.Text.RegularExpressions;)

            Console.WriteLine("La letra seleccionada se repite " + contador + " veces");
            Console.WriteLine("Fin del programa");

            Console.Read();
        }
    }

}
