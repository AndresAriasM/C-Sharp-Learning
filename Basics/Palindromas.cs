using System;
using System.Text.RegularExpressions;

namespace Palindromas
{
    class Program
    {
 
        static bool CumpleCondicion (string p)
        {
            int principio = 0;
            int final = p.Length;

            while (principio < final)
            {
                if (p[principio] != p[final]) 
                {
                    return false;                    
                }

                principio++;
                final--;
            }

            return true;

            
        }

        static void Main(string[] args)
        {

            Console.WriteLine("El programa te dira si tu palabra es palindroma");
            Console.WriteLine("Ingrese una palabra aleatoria");
            string palabra = Console.ReadLine();
            
            Console.WriteLine("¿La palabra cumple?");
            Console.WriteLine(CumpleCondicion(palabra));
 
            
            Console.Read();
        }
    }

}
