using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    interface iAdmon_Archivos
    {
        bool CargarArchivos(List<Servicio> servicios, string ruta);

        bool CargarRepuestos(List<Repuesto> repuestos, string ruta);
    }
}
