using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    abstract class Vehiculo
    {
        private string placa;
        private string modelo;
        private string combustible;
        private Cliente nombre;
        private Cliente cedula;
        private List<Cliente> clientes;
        private float valor_servicio_total = 0f;
        private string tipo_atencion;
        private string tamaño_vehiculo;

      
        public Vehiculo(string placa, string modelo, string combustible, Cliente nombre, Cliente cedula, string tipo_atencion, string tamaño_vehiculo)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Combustible = combustible;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Tipo_atencion = tipo_atencion;
            this.Tamaño_vehiculo = tamaño_vehiculo;

        
        }

        protected Vehiculo(float valor_servicio_total)
        {
            this.valor_servicio_total = valor_servicio_total;
        }

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Combustible { get => combustible; set => combustible = value; }
        internal Cliente Nombre { get => nombre; set => nombre = value; }
        internal Cliente Cedula { get => cedula; set => cedula = value; }
        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public float Valor_servicio_total { get => valor_servicio_total; set => valor_servicio_total = value; }
        public string Tipo_atencion { get => tipo_atencion; set => tipo_atencion = value; }
        public string Tamaño_vehiculo { get => tamaño_vehiculo; set => tamaño_vehiculo = value; }

        public virtual void RegistrarAtencion_Vehiculo(string nom_servicio, float valor_servicio, List<Atencion_Por_Vehiculo> atenciones_vehiculos, List<Vehiculo> vehiculos, List<Atencion> atenciones)
        {
            Console.WriteLine("Indique el número de placa del vehículo");
            string ced = Console.ReadLine();

            if (vehiculos.Exists(x => x.Placa == ced))
            {
                Vehiculo v2 = vehiculos.Find(x => x.Placa == ced);
                Atencion atencion = new Atencion(v2, DateTime.Now);
                Console.WriteLine($"Se atendera el vehículo {v2.Modelo} con placa {v2.Placa}");
                Console.WriteLine($"Vehículo registrado para servicio en {DateTime.Now}");
                atenciones.Add(atencion);

                Console.WriteLine("");
            }
        }

        public virtual void AñadirServicios_A_Vehiculo(List<Atencion_Por_Vehiculo> atenciones_vehiculos, Atencion_Por_Vehiculo a1)
        {
            atenciones_vehiculos.Add(a1);
            Console.WriteLine("Servicio añadido al vehículo");
        }

        public virtual void Impuesto_Por_Atencion(float factura, List<Vehiculo> vehiculos, Vehiculo v5)
        {
          if(v5.Tipo_atencion == "Preferencial")
          {
                float sobrecargo = factura * 0.08f;
                factura += sobrecargo;
                v5.Valor_servicio_total = factura;
          }
        }

        public virtual void Descuento_Combustible(float factura, List<Vehiculo> vehiculos, Vehiculo v5)
        {
            if (v5.Combustible == "Gas")
            {
                float sobrecargo = factura * 0.05f;
                factura -= sobrecargo;

                v5.Valor_servicio_total = factura;
            }
            if (v5.Combustible == "Diesel")
            {
                float sobrecargo = factura * 0.04f;
                factura -= sobrecargo;

                v5.Valor_servicio_total = factura;
            }
            if (v5.Combustible == "Gasolina")
            {
                float sobrecargo = factura * 0.03f;
                factura -= sobrecargo;

                v5.Valor_servicio_total = factura;
            }
        }

        public virtual void VehiculoPesado(float factura, List<Vehiculo> vehiculos)
        {

            if (vehiculos.Exists(x => x.Tamaño_vehiculo == "Vehiculo Pesado"))
            {
                Vehiculo v5 = vehiculos.Find(x => x.Tipo_atencion == "Vehiculo Pesado");
                float sobrecargo = factura * 0.05f;
                factura += sobrecargo;

                v5.Valor_servicio_total = factura;
            }
        }
        

        public abstract void GenerarIva(float factura, Vehiculo v1);



    } 
}
