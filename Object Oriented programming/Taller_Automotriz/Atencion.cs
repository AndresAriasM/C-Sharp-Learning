using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Atencion
    {
        
        private List<Atencion_Por_Vehiculo> atenciones_vehiculos = new List<Atencion_Por_Vehiculo>();
        private Vehiculo vehiculo_en_atencion;
        private DateTime fecha;

        public Atencion(Vehiculo vehiculo_en_atencion, DateTime fecha)
        {
            this.atenciones_vehiculos = atenciones_vehiculos;
            this.vehiculo_en_atencion = vehiculo_en_atencion;
            this.fecha = fecha;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal List<Atencion_Por_Vehiculo> Atenciones_vehiculos { get => atenciones_vehiculos; set => atenciones_vehiculos = value; }
        internal Vehiculo Vehiculo_en_atencion { get => vehiculo_en_atencion; set => vehiculo_en_atencion = value; }
    }
}
