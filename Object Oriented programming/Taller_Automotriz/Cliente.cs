using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Cliente
    {
        private string nombre;
        private string cedula;
        private DateTime fecha_registro;

        public Cliente(string nombre, string cedula, DateTime fecha_registro)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Fecha_registro = fecha_registro;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }

        public virtual void MenuServicio(List<Servicio> servicios, List<Vehiculo> vehiculos, List<Cliente> clientes, Cliente c3, string nombre_ser, List<Atencion> atenciones, List<Atencion_Por_Vehiculo> atenciones_vehiculos, List<Repuesto> repuestos)
        {
            if (servicios.Exists(x => x.Nombre_servicio == nombre_ser))
            {
                Servicio s1 = servicios.Find(x => x.Nombre_servicio == nombre_ser);

                if (vehiculos.Exists(x => x.Cedula == c3))
                {
                    Vehiculo v1 = vehiculos.Find(x => x.Cedula == c3);
                    v1.RegistrarAtencion_Vehiculo(nombre_ser, s1.Valor_servicio, atenciones_vehiculos, vehiculos, atenciones);

                    Console.WriteLine("¿El vehículo requiere de algún repuesto?");
                    Console.WriteLine("|                                       |");
                    Console.WriteLine("|              1. Si                    |");
                    Console.WriteLine("|              2. No                    |");
                    Console.WriteLine("-----------------------------------------");
                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("     Stock de repuestos");
                        Console.WriteLine("|   1. Visualizar stock    |");
                        Console.WriteLine("|   2. Modificar stock     |");
                        Console.WriteLine("----------------------------");
                        string ret = Console.ReadLine();

                        if (ret == "1")
                        {
                            Console.WriteLine("STOCK DE REPUESTOS");
                            Console.WriteLine("");
                            foreach (var item in repuestos)
                            {
                                Console.WriteLine($"Nombre del repuesto: {item.Nombre_repuesto} - Cantidad disponible: {item.Cantidad_repuesto} - Codigo repuesto: {item.Codigo_repuesto} - Valor repuesto: {item.Valor_repuesto}");
                            }
                        }
                        else if (ret == "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("                  Digite el código del repuesto a modificar                        ");
                            Console.WriteLine("NOTA: Debe escribir el código exactamente igual a como aparece en la lista anterior");
                            Console.WriteLine("SI USTED ESTA EN ESTA SECCIÓN ES PORQUE VA A TOMAR ALGÚN REPUESTO PARA UN SERVICIO");
                            string opti = Console.ReadLine();

                            if (repuestos.Exists(x => x.Codigo_repuesto == opti))
                            {
                                Repuesto r1;
                                r1 = repuestos.Find(x => x.Codigo_repuesto == opti);
                                Console.WriteLine("Introduzca las unidades que desea tomar para el servicio");
                                float unid = float.Parse(Console.ReadLine());

                                r1.ModificarRepuestoReducir(unid, opti, repuestos);
                                Console.WriteLine("Stock modificado satisfactoriamente");

                                Atencion_Por_Vehiculo a1 = new Atencion_Por_Vehiculo(r1.Nombre_repuesto, nombre_ser, s1.Valor_servicio, v1);
                                v1.AñadirServicios_A_Vehiculo(atenciones_vehiculos, a1);

                            }
                        }
                    }

                    else if (option == "2")
                    {
                        Atencion_Por_Vehiculo a1 = new Atencion_Por_Vehiculo("Ningún repuesto empleado", nombre_ser, s1.Valor_servicio, v1);
                        v1.AñadirServicios_A_Vehiculo(atenciones_vehiculos, a1);
                    }

                }
            }
        }
    }
}
