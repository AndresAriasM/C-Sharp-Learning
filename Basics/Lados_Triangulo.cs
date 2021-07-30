using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore un programa que lea tres enteros positivos y que determine si pueden formar triángulo o no.Si pueden
            //formar triángulo, debe imprimir qué clase de triángulo es: equilátero, isósceles o escaleno.Tres enteros forman
            //triángulo si cada uno de ellos es menor que la suma de los otros dos.

            Console.WriteLine("Indique las medidas de cada lado de su triangulo");

            Console.WriteLine("Inserte la medida en CMS de uno de sus lados");

            string vinicial = Console.ReadLine();
            int numero_1 = int.Parse(vinicial);

            Console.WriteLine("Inserte la medida en CMS de otro de sus lados");

            string vmedio = Console.ReadLine();
            int numero_2 = int.Parse(vmedio);

            Console.WriteLine("Inserte la medida en CMS del ultimo lado del triangulo");

            string vfinal = Console.ReadLine();
            int numero_3 = int.Parse(vfinal);


            if (numero_1 == numero_2 && numero_2 == numero_3)
            {
                Console.WriteLine("Este es un triangulo equilatero");
            }

            else if (numero_1 != numero_2 && numero_1 == numero_3)
            {
                Console.WriteLine("Este es un triangulo isoceles");
            }

            else if (numero_1 != numero_3 && numero_1 == numero_2)
            {
                Console.WriteLine("Este es un triangulo isoceles");
            }

            else if (numero_2 != numero_3 && numero_1 == numero_2)
            {
                Console.WriteLine("Este es un triangulo isoceles");
            }

            else if (numero_1 != numero_2 && numero_2 == numero_3)
            {
                Console.WriteLine("Este es un triangulo isoceles");
            }
            else
            {
                Console.WriteLine("Este es un triangulo escaleno");
            }

            Console.Read();
        }
    }
    
}

