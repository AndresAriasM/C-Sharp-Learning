using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace TallerAutomotriz_Final
{
    class Admon_Texto : iAdmon_Archivos
    {

        public bool CargarArchivos(List<Servicio> servicios, string ruta)
        {
            StreamReader lector = new StreamReader(ruta);
            string linea = lector.ReadLine(); //La primera
            string[] vectorservicios;
            int cont = 0;
            do
            {
                if (cont < 9)
                {
                    cont++;
                    vectorservicios = linea.Split(',');

                    Servicio servicio = new Servicio(vectorservicios[0], vectorservicios[1], float.Parse(vectorservicios[2]));
                    servicios.Add(servicio);
                    linea = lector.ReadLine();
                }
                else
                {
                    linea = lector.ReadLine();
                }


            } while (linea != null);

            lector.Close();
            return true;
        } 

        public bool CargarRepuestos(List<Repuesto> repuestos, string ruta)
        {
            StreamReader lector = new StreamReader(ruta);
            string linea = lector.ReadLine(); //La primera
            string[] vectorrepuestos;
            int cont = 0;
            do
            {
                if (cont < 18)
                {
                    cont++;
                    vectorrepuestos = linea.Split(',');

                    Repuesto repuesto = new Repuesto(vectorrepuestos[0], float.Parse(vectorrepuestos[1]), vectorrepuestos[2], float.Parse(vectorrepuestos[3]));
                    repuestos.Add(repuesto);
                    linea = lector.ReadLine();
                }
                else
                {
                    linea = lector.ReadLine();
                }


            } while (linea != null);

            lector.Close();
            return true;
        }
    }

}

