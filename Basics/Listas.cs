using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace Listas
{
    class Program
    {

        static void Lista(List<string> musica)
        {
            Console.WriteLine("Lista de canciones:");
            foreach (var item in musica)
            {
                Console.WriteLine(musica.IndexOf(item) + " " + item);
            }
        }

        static void Incluir(List<string> nuevacancion)
        {
            Console.WriteLine("¿Qué canción desea incluir?");
            string nueva = Console.ReadLine();

            if (nueva != null)
            {
                if (!nuevacancion.Contains(nueva))
                {
                    nuevacancion.Add(nueva);
                }
            }
        }

        static void Eliminar(List<string> Borrar)
        {
            Console.WriteLine("Digite la canción que quiere elminar");
            string seleccion = Console.ReadLine();

            if (Borrar.Contains(seleccion))
            {
                Borrar.Remove(seleccion);
            }
        }

        static void Actualizar(List<string> Elemento)
        {


            Console.WriteLine("Escriba el nombre de la canción que desea eliminar");
            string opcion = Console.ReadLine();


            if (Elemento.Contains(opcion))
            {
                Console.WriteLine("Ingrese el nuevo nombre");
                string nueva = Console.ReadLine();

                Elemento.Add(nueva);
                Elemento.Remove(opcion);
            }
        }

        static void Main(string[] args)
        {
            List<string> canciones = new List<string>();

            canciones.Add("Lady");
            canciones.Add("By your side");
            canciones.Add("I wanna know");
            canciones.Add("Breathe");
            canciones.Add("Be someone");
            canciones.Add("Calle 13");

            int eleccion;
            do
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Bienvenido al reproductor de canciones libre");
                    Console.WriteLine("");
                    Console.WriteLine("Estas son las opciones de las que dispone:");
                    Console.WriteLine("1. Mostrar lista de canciones de forma ascendente");
                    Console.WriteLine("2. Mostrar lista de canciones de forma descendente");
                    Console.WriteLine("3. Adicionar una nueva canción");
                    Console.WriteLine("4. Actualizar el nombre de una canción");
                    Console.WriteLine("5. Eliminar una canción de la lista");
                    Console.WriteLine("6. Imprimir lista de canciones");
                    Console.WriteLine("7. Finalizar programa");

                    eleccion = Convert.ToInt32(Console.ReadLine());

                    switch (eleccion)
                    {
                        case 1:
                            Lista(canciones);
                            break;

                        case 2:
                            Lista(canciones);
                            break;

                        case 3:
                            Incluir(canciones);
                            break;

                        case 4:
                            Actualizar(canciones);
                            break;

                        case 5:
                            Eliminar(canciones);
                            break;

                        case 6:
                            Lista(canciones);
                            break;

                        case 7:
                            Console.WriteLine("Fin del programa");
                            break;

                        default:
                            Console.WriteLine("Usted ingreso un valor incorrecto");
                            break;

                    }
                } while (eleccion >= 1 || eleccion <= 7);

            } while (Convert.ToString(eleccion) != "" && eleccion != 7);
        }
    }
}
