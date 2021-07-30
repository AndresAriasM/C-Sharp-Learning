using System;

namespace Triangulos_Final
{
    class Program
    {
   

        static void Main(string[] args)
        {
            //Elabore un programa que lea tres enteros positivos y que determine si pueden formar triángulo o no.Si pueden
            //formar triángulo, debe imprimir qué clase de triángulo es: equilátero, isósceles o escaleno.Tres enteros forman
            //triángulo si cada uno de ellos es menor que la suma de los otros dos.

            Console.WriteLine("Bienvenido al identificador de triangulos");
            Console.WriteLine("Se le pedira que ingrese la medida de cada lado del triangulo");


            string enter = "";

            string vinicial = "";

            string vmedio = "";

            string vfinal = "";

            int numero_1;
            int numero_2;
            int numero_3;

            int variable_1;
            int variable_2;
            int variable_3;
       
            do
            {

                Console.WriteLine("Pulse la tecla Enter para continuar");

                if (enter.Equals(""))
                {
                    enter = Console.ReadLine();
                    Console.WriteLine("Inserte la medida en CMS de uno de sus lados");
                }

                vinicial = Console.ReadLine();

                numero_1 = int.Parse(vinicial);

                Console.WriteLine("Inserte la medida en CMS de otro de sus lados");
                vmedio = Console.ReadLine();
                numero_2 = int.Parse(vmedio);

                Console.WriteLine("Inserte la medida en CMS del ultimo lado del triangulo");
                vfinal = Console.ReadLine();
                numero_3 = int.Parse(vfinal);

                variable_1 = numero_1 + numero_2;
                variable_2 = numero_1 + numero_3;
                variable_3 = numero_2 + numero_3;

                if (variable_1 < numero_3)
                {
                    Console.WriteLine("Lo siento, los lados ingresados no permiten la formación de un triangulo");
                }

                else if (variable_2 < numero_2)
                {
                    Console.WriteLine("Lo siento, los lados ingresados no permiten la formación de un triangulo");
                }

                else if (variable_3 < numero_1)
                {
                    Console.WriteLine("Lo siento, los lados ingresados no permiten la formación de un triangulo");
                }

                else
                {
                    Console.WriteLine("La formación del triangulo si es posible");
                }

            } while (variable_1 < numero_3 && variable_2 < numero_2 && variable_3 < numero_1);

            if (variable_1 > numero_3 && variable_2 > numero_2 && variable_3 > numero_1)
            {
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
            }

            Console.WriteLine("Fin del programa");

            Console.Read();
        }
    }

}
