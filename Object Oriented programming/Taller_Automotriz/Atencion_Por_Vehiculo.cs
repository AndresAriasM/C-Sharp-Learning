using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Atencion_Por_Vehiculo
    {
        private Servicio servicios;
        private List<Repuesto> repuestos = new List<Repuesto>();
        private Vehiculo vehiculo_trabajado;
        private string repuesto_utilizado;
        private string servicio_vehiculo;
        private float valor_atencion;

        public Atencion_Por_Vehiculo(string repuesto_utilizado, string servicio_vehiculo, float valor_atencion, Vehiculo vehiculo_trabajado)
        {
            this.valor_atencion = valor_atencion;
            this.Repuesto_utilizado = repuesto_utilizado;
            this.Servicio_vehiculo = servicio_vehiculo;
            this.Vehiculo_trabajado = vehiculo_trabajado;
        }

        public float Valor_atencion { get => valor_atencion; set => valor_atencion = value; }
        public string Repuesto_utilizado { get => repuesto_utilizado; set => repuesto_utilizado = value; }
        public string Servicio_vehiculo { get => servicio_vehiculo; set => servicio_vehiculo = value; }
        internal List<Repuesto> Repuestos { get => repuestos; set => repuestos = value; }
        internal Vehiculo Vehiculo_trabajado { get => vehiculo_trabajado; set => vehiculo_trabajado = value; }
        internal Servicio Servicios { get => servicios; set => servicios = value; }
    }
}
