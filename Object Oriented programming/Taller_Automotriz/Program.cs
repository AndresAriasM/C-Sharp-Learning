using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TallerAutomotriz_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atencion> atenciones = new List<Atencion>();
            List<Atencion_Por_Vehiculo> atenciones_vehiculos = new List<Atencion_Por_Vehiculo>();
            List<Cliente> clientes = new List<Cliente>();
            List<Servicio> servicios = new List<Servicio>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Repuesto> repuestos = new List<Repuesto>();

            Admon_Texto archivoTexto = new Admon_Texto();
            archivoTexto.CargarArchivos(servicios, "C:\\Users\\Andres Arias\\Downloads\\Servicios_Taller.txt");
            archivoTexto.CargarRepuestos(repuestos, "C:\\Users\\Andres Arias\\Downloads\\Repuestos.txt");

            Console.WriteLine("\n");


            Console.WriteLine("|             Bienvenido al TALLER AUTOMOTRIZ                   |");
            Console.WriteLine("|---------------------------------------------------------------|");
            Console.WriteLine("|Querido Usuario(a) por favor indique su relación con el cliente|");
            Console.WriteLine("");
            Console.WriteLine("                     |1. Cliente  |");
            Console.WriteLine("                     |2. Personal |");
            Console.WriteLine("");

            int inicio = int.Parse(Console.ReadLine());
            do
            {
                if (inicio == 1)
                {
                    MenuClientes(vehiculos, clientes, atenciones, atenciones_vehiculos, repuestos);

                }
                else if (inicio == 2)
                {
                    Console.WriteLine("Por favor introduzca el código de la empresa");
                    string codigo = Console.ReadLine();

                    if (codigo.Equals("1942"))
                    {
                        int opcion;
                        do
                        {
                            Console.WriteLine("");
                            MenuPersonal();

                            Console.WriteLine("");
                            opcion = int.Parse(Console.ReadLine());


                            switch (opcion)
                            {
                                case 1: //Registrar vehiculo

                                    RegistrarVehiculo(clientes, vehiculos);

                                    break;

                                case 2: //Mostrar lista clientes

                                    MostrarInformacionCliente(clientes, vehiculos);

                                    break;

                                case 3: // Indicar servicios requeridos o solictados por el cliente


                                    foreach(var item in servicios)
                                    {
                                        Console.WriteLine($"Nombre servicio: {item.Nombre_servicio} - Codigo servicio: {item.Codigo_servicio} - Valor: {item.Valor_servicio}");
                                    }

                                    MenuServicios(clientes, vehiculos, repuestos, servicios, atenciones, atenciones_vehiculos);


                                    break;

                                case 4:

                                    Console.WriteLine("STOCK DE REPUESTOS");
                                    Console.WriteLine("");
                                    foreach (var item in repuestos)
                                    {
                                        Console.WriteLine($"Nombre del repuesto: {item.Nombre_repuesto} - Cantidad disponible: {item.Cantidad_repuesto} - Codigo repuesto: {item.Codigo_repuesto} - Valor repuesto: {item.Valor_repuesto}");
                                    }

                                    break;

                                case 5:

                                    ModificarStock(repuestos);

                                    break;

                                case 6:

                                    GenerarCostos(vehiculos, clientes, atenciones, atenciones_vehiculos, repuestos);

                                    break;

                                case 7:
                                    
                                    EliminarVehiculo(clientes, vehiculos);

                                    break;

                                case 8:

                                    MenuClientes(vehiculos, clientes, atenciones, atenciones_vehiculos, repuestos);
                                    break;
                            }

                        } while (opcion != 9);

                    }
                }
            } while (inicio != 1 && inicio != 2);
        }

        public static void MenuClientes(List<Vehiculo> vehiculos, List<Cliente> clientes, List<Atencion> atenciones, List<Atencion_Por_Vehiculo> atenciones_vehiculos, List<Repuesto> repuestos)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido(a) estimado(a) usuario(a)");
            Console.WriteLine("A continuación se le proporcionaran unas opciones");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|1. Agendar cita                                |");
            Console.WriteLine("|2. Verificar el status de mi vehiculo          |");
            Console.WriteLine("|3. Visualizar el costo del servicio solicitado |");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            string option = Console.ReadLine();

            if(option == "1")
            {
                DateTime RandomDay() 
                { DateTime start = new DateTime(2021, 11, 4); 
                    Random gen = new Random(); int range = (DateTime.Today - start).Days; 
                    return start.AddDays(gen.Next(range)); 
                }

                Console.WriteLine("");
                Console.WriteLine("          A continuación se le asiganara una fecha aleatoria");
                Console.WriteLine("En el caso de que desee cambiarla puede comunicarse con la linea 3192586787");
                Console.WriteLine("");
                Console.WriteLine("La cita para su vehículo queda para " + RandomDay());
            }

            if(option == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese su número de cédula");
                string ced = Console.ReadLine();

                if(clientes.Exists(x => x.Cedula == ced))
                {
                    Console.WriteLine("Su vehículo ha sido registrado y esta siendo atendido por nuestros mecánicos");
                    Console.WriteLine("        Para mas información comuniquese con la linea 3192586787 ");
                }
                else
                {
                    Console.WriteLine("Su vehículo no ha sido registrado en el taller de momento");
                    Console.WriteLine("Para mas información comuniquese con la linea 3192586787 ");
                }
            }

            if(option == "3")
            {
                GenerarCostos(vehiculos, clientes, atenciones, atenciones_vehiculos, repuestos);
            }

            Console.Read();
        }

        public static void MenuPersonal()
        {

            Console.WriteLine("||| Querid@ emplead@ recuerde que unicamente puede registrarse un vehículo por cliente |||");
            Console.WriteLine("||| Una vez el vehículo sea atendido, proceda a eliminarlo del sistema con la opción 7 |||");
            Console.WriteLine("");
            Console.WriteLine("                        Bienvenido(a) querido(a) empleado(a)");
            Console.WriteLine("                     Seleccione alguna de las opciones presentadas");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("|           |||1. Registrar un vehiculo                                     |||          |");
            Console.WriteLine("|           |||2. Ver información de un cliente                             |||          |");
            Console.WriteLine("|           |||3. Indicar servicios requeridos o solicitados por el cliente |||          |");
            Console.WriteLine("|           |||4. Visualizar el stock de taller                             |||          |");
            Console.WriteLine("|           |||5. Modificar el stock del taller                             |||          |");
            Console.WriteLine("|           |||6. Mostrar el valor total de un vehiculo                     |||          |");
            Console.WriteLine("|           |||7. Eliminar vehículo del sistema manualmente                 |||          |");
            Console.WriteLine("|           |||8. Mostrar el menú de los clientes                           |||          |");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("");

        }

        public static void RegistrarVehiculo(List<Cliente> clientes, List<Vehiculo> vehiculos)
        {
            string cliente;
            do
            {
                Console.WriteLine("Ingrese el nombre completo del cliente");
                cliente = Console.ReadLine();

            } while (cliente == "");

            string cedula;
            do
            {
                Console.WriteLine("Digite el número de cédula del cliente");
                cedula = Console.ReadLine();

            } while (cedula == "");

            Cliente c1 = new Cliente(cliente, cedula, DateTime.Now);
            clientes.Add(c1);

            Console.WriteLine("");
            Console.WriteLine("A continuación se le pediran los datos del vehículo");
            Console.WriteLine("");

            string placa;
            do
            {
                Console.WriteLine("Digite la placa del vehículo");
                placa = Console.ReadLine();

            } while (placa == "");

            string modelo;
            do
            {
                Console.WriteLine("Escriba el modelo del vehículo");
                modelo = Console.ReadLine();

            } while (modelo == "");
            

            Console.WriteLine("¿Qué tipo de combustible usa el vehículo");
            Console.WriteLine("Ingrese el número correspondiente");
            Console.WriteLine("");
            Console.WriteLine("1. Diesel");
            Console.WriteLine("2. Gas");
            Console.WriteLine("3. Gasolina");
            string combustible = Console.ReadLine();

            if (combustible == "1")
            {
                combustible = "Diesel";
            }
            else if (combustible == "2")
            {
                combustible = "Gas";
            }
            else if (combustible == "3")
            {
                combustible = "Gasolina";
            }
            else
            {
                Console.WriteLine("Error de digitación, el número ingresado no corresponde");
            }

            Console.WriteLine("| Especifique el tipo de atención solicitado  |");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|         1. Por defecto                      |");
            Console.WriteLine("|         2. Preferencial                     |");
            Console.WriteLine("-----------------------------------------------");

            string aten = Console.ReadLine();

            if(aten == "1")
            {
                aten = "Por defecto";
            }
            else if (aten == "2")
            {
                aten = "Preferencial";
            }
            else
            {
                Console.WriteLine("Error de digitación, opción no valida");
            }

            Console.WriteLine("Seleccione la categoria del vehículo");
            Console.WriteLine("");
            Console.WriteLine("1. Vehículo liviano");
            Console.WriteLine("2. Vehículo pesado");
            int tpo = int.Parse(Console.ReadLine());
            Vehiculo v1;

            if (tpo == 1)
            {
                string tam = "Liviano";
                v1 = new Vehiculo_Liviano(placa, modelo, combustible, c1, c1, aten, tam);
                vehiculos.Add(v1);
            }
            else if (tpo == 2)
            {
                string tam = "Pesado";
                v1 = new Vehiculo_Pesado(placa, modelo, combustible, c1, c1, aten, tam);
                vehiculos.Add(v1);
            }
            else
            {
                Console.WriteLine("Valor ingresado erroneo");
            }

        }

        public static void MostrarInformacionCliente(List<Cliente> clientes, List<Vehiculo> vehiculos)
        {
            Console.WriteLine("Introduzca el número de cédula del cliente");
            string num = Console.ReadLine();
            Cliente c2;
            Vehiculo v1;

            if (clientes.Exists(x => x.Cedula == num))
            {
                c2 = clientes.Find(x => x.Cedula == num);

                if (vehiculos.Exists(x => x.Cedula == c2))
                {
                    v1 = vehiculos.Find(x => x.Cedula == c2);

                    Console.WriteLine("");
                    Console.WriteLine($"Cliente: {c2.Nombre} Cédula: {c2.Cedula}");
                    Console.WriteLine("");
                    Console.WriteLine("VEHÍCULOS");
                    Console.WriteLine("");
                    Console.WriteLine($"Placa: {v1.Placa}, Modelo: {v1.Modelo}, Combustible: {v1.Combustible}, Tipo de atención: {v1.Tipo_atencion}, Tamaño del vehículo: {v1.Tamaño_vehiculo}");
                }
                else
                {
                    Console.WriteLine("El número de cédula registrado no corresponde a ningun vehículo");
                    Console.WriteLine("");
                }
            }  
        }

        public static void MenuServicios(List<Cliente> clientes, List<Vehiculo> vehiculos, List<Repuesto> repuestos, List<Servicio> servicios, List<Atencion> atenciones, List<Atencion_Por_Vehiculo> atenciones_vehiculos)
        {
            Console.WriteLine("Por favor ingrese el número de cédula del cliente");
            string num_cedula = Console.ReadLine();
            Cliente c3;

            if (clientes.Exists(x => x.Cedula == num_cedula))
            {
                c3 = clientes.Find(x => x.Cedula == num_cedula);
                Console.WriteLine("");
                Console.WriteLine("Bienvenido(a) querido(a) empleado(a) la interfaz de servicios");
                Console.WriteLine("Seleccione los servicios requeridos para el vehículo en cuestión");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("|1. Lavada y aspirada                                         |");
                Console.WriteLine("|2. Revisión tecnico mecanica                                 |");
                Console.WriteLine("|3. Revisión de aceite y liquido refrigerante                 |");
                Console.WriteLine("|4. Cambio de llantas                                         |");
                Console.WriteLine("|5. Pintura                                                   |");
                Console.WriteLine("|6. Reparación de pieza por colisión                          |");
                Console.WriteLine("|7. Cambio de pieza por colisión                              |");
                Console.WriteLine("|8. Cambio de luces                                           |");
                Console.WriteLine("|9. Mantenimiento del sistema electrico                       |");
                Console.WriteLine("|10. Revisión del motor                                       |");
                Console.WriteLine("|11. Otra opción                                              |");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    string nombre_ser = "Lavada y aspirada";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                   
                }
                else if(opcion == "2")
                {
                    string nombre_ser = "Revisión tecnico-mecanica";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "3")
                {
                    string nombre_ser = "Revisión aceite - liquido refrigerante";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "4")
                {
                    string nombre_ser = "Cambio llantas";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "5")
                {
                    string nombre_ser = "Pintura";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "6")
                {
                    string nombre_ser = "Reparación pieza colisión";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "7")
                {
                    string nombre_ser = "Cambio pieza colisión";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "8")
                {
                    string nombre_ser = "Cambio luces";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "9")
                {
                    string nombre_ser = "Mantenimiento sistema electrico";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if(opcion == "10")
                {
                    string nombre_ser = "Revisión del motor";
                    c3.MenuServicio(servicios, vehiculos, clientes, c3, nombre_ser, atenciones, atenciones_vehiculos, repuestos);
                }
                else if (opcion == "11")
                {
                    Console.WriteLine("Escriba el nombre del servicio que desea crear");
                    string nom_ser = Console.ReadLine();

                    Console.WriteLine("Digite el codigo del servicio a crear");
                    string cod_ser = Console.ReadLine();

                    Console.WriteLine("Digite el valor del servicio que desea crear");
                    float val_ser = float.Parse(Console.ReadLine());

                    Servicio se1 = new Servicio(nom_ser, cod_ser, val_ser);
                    se1.AñadirNuevoServicio(nom_ser, cod_ser, val_ser, servicios);
                    string nuevoser = nom_ser + "," + cod_ser + "," + val_ser.ToString();
                    File.AppendAllText("Servicios.txt", nuevoser + Environment.NewLine);
                }
            }
        }    

        public static void GenerarCostos(List<Vehiculo> vehiculos, List<Cliente> clientes, List<Atencion> atenciones, List<Atencion_Por_Vehiculo> atenciones_vehiculos, List<Repuesto> repuestos)
        {
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese el número de cédula del cliente");
            string cedula = Console.ReadLine();

            if(clientes.Exists(x => x.Cedula == cedula))
            {
                Cliente c4 = clientes.Find(x => x.Cedula == cedula);

                if(vehiculos.Exists(x => x.Cedula == c4))
                {
                    Vehiculo v4 = vehiculos.Find(x => x.Cedula == c4);
                    Console.WriteLine("");
                    Console.WriteLine($"La siguiente factura se le hara al vehículo {v4.Modelo} de placa {v4.Placa}");

                    if(atenciones.Exists(x => x.Vehiculo_en_atencion == v4))
                    {
                        Atencion a1 = atenciones.Find(x => x.Vehiculo_en_atencion == v4);
                        
                        if(atenciones_vehiculos.Exists(x => x.Vehiculo_trabajado == a1.Vehiculo_en_atencion))
                        {
                            Atencion_Por_Vehiculo aten1 = atenciones_vehiculos.Find(x => x.Vehiculo_trabajado == a1.Vehiculo_en_atencion);

                            if(repuestos.Exists(x => x.Nombre_repuesto == aten1.Repuesto_utilizado))
                            {
                                Repuesto r1 = repuestos.Find(x => x.Nombre_repuesto == aten1.Repuesto_utilizado);

                                float factura = aten1.Valor_atencion + r1.Valor_repuesto;

                                v4.GenerarIva(factura, v4);
                                v4.Impuesto_Por_Atencion(factura, vehiculos, v4);
                                v4.Descuento_Combustible(factura, vehiculos, v4);

                                Console.WriteLine("FACTURA");
                                Console.WriteLine($"- {aten1.Valor_atencion} ---------  {aten1.Servicio_vehiculo} +");
                                Console.WriteLine($"- {r1.Valor_repuesto}  ------------ {r1.Nombre_repuesto}");
                                Console.WriteLine("A estos valores se les aplican sobrecostos como el iva, tipo de servicio y caractersiticas especiales del vehículo Y Q");

                                Console.WriteLine($"El vehículo {v4.Modelo} de placa {v4.Placa}");
                                Console.WriteLine($"El costo total del servicio es {v4.Valor_servicio_total} PESOS $");
                            }
                        }
                    }
                }
            }
        }
        public static void ModificarStock(List<Repuesto> repuestos)
        {
            Console.WriteLine("");
            Console.WriteLine("| Escoja una de las siguientes opciones |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| 1. Modificar un repuesto ya existente |");
            Console.WriteLine("| 2. Añadir un nuevo repuesto           |");
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("");
            string op = Console.ReadLine();

            if (op == "1")
            {
                Console.WriteLine("Esta es la lista vigente de repuestos del taller");
                Console.WriteLine("");

                Console.WriteLine("STOCK DE REPUESTOS");
                Console.WriteLine("");
                foreach (var item in repuestos)
                {
                    Console.WriteLine($"Nombre del repuesto: {item.Nombre_repuesto} - Cantidad disponible: {item.Cantidad_repuesto} - Codigo repuesto: {item.Codigo_repuesto} - Valor repuesto: {item.Valor_repuesto}");
                }
                Console.WriteLine("");
                Console.WriteLine("                  Digite el código del repuesto a modificar");
                Console.WriteLine("NOTA: Debe escribir el código exactamente igual a como aparece en la lista anterior");
                string opti = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("| ¿Qué opción desea implementar? |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|     1. Aumentar repuestos      |");
                Console.WriteLine("|     2. Reducir repuestos       |");
                Console.WriteLine("|     3. Eliminar repuesto       |");
                Console.WriteLine("----------------------------------");

                string opi = Console.ReadLine();

                if (opi == "1")
                {                  
                    if (repuestos.Exists(x => x.Codigo_repuesto == opti))
                    {
                        Repuesto r1;
                        r1 = repuestos.Find(x => x.Codigo_repuesto == opti);
                        Console.WriteLine("Introduzca las unidades que desea añadir");
                        float unid = float.Parse(Console.ReadLine());

                        r1.ModificarRepuestoAumentar(unid, opti, repuestos);
                        Console.WriteLine("Stock modificado satisfactoriamente");
                    }
                }
                else if (opi == "2")
                {
                    if (repuestos.Exists(x => x.Codigo_repuesto == opti))
                    {
                        Repuesto r1;
                        r1 = repuestos.Find(x => x.Codigo_repuesto == opti);
                        Console.WriteLine("Introduzca las unidades que desea reducir");
                        float unid = float.Parse(Console.ReadLine());

                        r1.ModificarRepuestoReducir(unid, opti, repuestos);
                        Console.WriteLine("Stock modificado satisfactoriamente");
                    }
                }
                else if (opi == "3")
                {
                    if (repuestos.Exists(x => x.Codigo_repuesto == opti))
                    {
                       
                        Repuesto r1 = repuestos.Find(x => x.Codigo_repuesto == opti);
                        r1.EliminarRepuesto(repuestos, opti);
                        Console.WriteLine("Repuesto eliminado satisfactoriamente");
                    }
                }

            }

            else if(op == "2")
            {
                Console.WriteLine("Digite el nombre del nuevo repuesto");
                string nom = Console.ReadLine();

                Console.WriteLine("Ingrese las unidades disponibles en stock");
                int uni = int.Parse(Console.ReadLine());

                Console.WriteLine("Añada un código de stock");
                string cod = Console.ReadLine();

                Console.WriteLine("Indique el valor del servicio");
                float valu = float.Parse(Console.ReadLine());

                Repuesto r1 = new Repuesto(nom, uni, cod, valu);
               
                r1.AñadirNuevoRepuesto(nom, uni, cod, valu, repuestos);

                string nuevorep = nom + "," + uni.ToString() + "," + cod + "," + valu.ToString();
                File.AppendAllText("Repuestos.txt", nuevorep + Environment.NewLine);

            }
        }

        public static void EliminarVehiculo(List<Cliente> clientes, List<Vehiculo> vehiculos)
        {
            Console.WriteLine("Introduzca el número de cédula del cliente");
            string num = Console.ReadLine();
            Cliente c2;
            Vehiculo v1;

            if (clientes.Exists(x => x.Cedula == num))
            {
                c2 = clientes.Find(x => x.Cedula == num);

                if (vehiculos.Exists(x => x.Cedula == c2))
                {
                    v1 = vehiculos.Find(x => x.Cedula == c2);

                    vehiculos.Remove(v1);

                    Console.WriteLine("¡Vehículo eliminado satisfactoriamente!");
                    Console.WriteLine("");
                }
            }
        }

        
    }
}
