using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace Contabilidad_Empresa
{
    class Program
    {
        public static int[] VentasAño(int[,] tabla)
        {
            int suma;
            int[] VtasTotal = null;

            if (tabla != null)
            {
                VtasTotal = new int[tabla.GetLength(1)];
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    suma = 0;
                    for (int i = 0; i < tabla.GetLength(0); i++)
                    {
                        suma += tabla[i, j];
                    }
                    VtasTotal[j] = suma;
                }
            }    

            return VtasTotal;
        }

        public static int[] VentasVendedor(int[,] tabla)
        {
            int suma;
            int[] VenTotal = null;

            if (tabla != null)
            {
                VenTotal = new int[tabla.GetLength(1)];
                for (int i = 0; i < tabla.GetLength(0); i++)
                {
                    suma = 0;
                    for (int j = 0; j < tabla.GetLength(1); j++)
                    {
                        suma += tabla[i, j];
                    }
                    VenTotal[i] = suma;
                }
            }

            return VenTotal;
        }

        public static void PrimerVector(int[] vector)
        {
            foreach (var item in vector)
            {
                Console.Write(" " + item + ", ");
            }

            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de vendedores de su empresa");
            int numvendedores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique el número de años de las ventas que desea calcular");
            int numaños = Convert.ToInt32(Console.ReadLine());

            int[,] tabla = new int [numaños, numvendedores];

            for (int filas = 0; filas < numaños; filas++)
            {
                for (int columnas = 0; columnas < numvendedores; columnas++)
                {
                    Console.WriteLine($"Cuales fueron las ventas del vendedor {filas+1} en el año {columnas+1}");
                    tabla[filas, columnas] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Estos son los datos ingresados, las filas corresponden a las ventas");
            Console.WriteLine("por vendedor y las columnas muestran las ventas por año:");
            Console.WriteLine("");

            for (int filas = 0; filas < tabla.GetLength(0); filas++) // Mostrar la tabla o matriz
            {
                for (int columnas = 0; columnas < tabla.GetLength(1); columnas++)
                {
                    
                    Console.Write(" " + tabla[filas, columnas] + " | ");
                }

                Console.WriteLine();
            }

            int[] Ventas_Año = VentasAño(tabla); 
            PrimerVector(Ventas_Año);

            int[] Ventas_Vendedor = VentasVendedor(tabla);
            PrimerVector(Ventas_Vendedor);

        }
    }
}
