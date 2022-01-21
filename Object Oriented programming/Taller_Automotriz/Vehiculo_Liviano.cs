using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Vehiculo_Liviano : Vehiculo
    {
        public Vehiculo_Liviano(string placa, string modelo, string combustible, Cliente nombre, Cliente cedula, string tipo_atencion, string tamaño_vehiculo) : base(placa, modelo, combustible, nombre, cedula, tipo_atencion, tamaño_vehiculo)
        {
            
        }

        public override void GenerarIva(float factura, Vehiculo v1)
        {
            float iva = 0.19f;
            float monto = (iva* factura);
            factura += monto;

            v1.Valor_servicio_total = factura;
        }


        
    }
}
