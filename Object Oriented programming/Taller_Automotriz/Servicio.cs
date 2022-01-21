using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Servicio
    {
        private string nombre_servicio;
        private string codigo_servicio;
        private float valor_servicio;

        public Servicio(string nombre_servicio, string codigo_servicio, float valor_servicio)
        {
            this.Nombre_servicio = nombre_servicio;
            this.Codigo_servicio = codigo_servicio;
            this.Valor_servicio = valor_servicio;
        }

        public string Nombre_servicio { get => nombre_servicio; set => nombre_servicio = value; }
        public string Codigo_servicio { get => codigo_servicio; set => codigo_servicio = value; }
        public float Valor_servicio { get => valor_servicio; set => valor_servicio = value; }

        public virtual void AñadirNuevoServicio(string nuevo_servicio, string nuevo_codigo, float nuevo_valor, List<Servicio> servicios)
        {
            if (nuevo_servicio != null)
            {
                Servicio ser1 = new Servicio(nuevo_servicio, nuevo_codigo, nuevo_valor);
                servicios.Add(ser1);
            }
        }

        /*
        public virtual void AñadirServicios(List<Servicio> servicios)
        {
            int lavada_y_aspirada = 0;
            string cod1 = "0001";
            float pre1 = 30000f;

            Servicio ser1 = new Servicio(lavada_y_aspirada, cod1, pre1); // LAVADA Y ASPIRADA
            servicios.Add(ser1);

            int revisiontecnicomecanica = 0;
            string cod2 = "0002";
            float pre2 = 120000f;

            Servicio ser2 = new Servicio(revisiontecnicomecanica, cod2, pre2); // Revisión Tecnico-Mecanica
            servicios.Add(ser2);

            int aceite_liquidos = 0;
            string cod3 = "0003";
            float pre3 = 70000f;

            Servicio ser3 = new Servicio(aceite_liquidos, cod3, pre3); // Aceite y liquido refrigerante
            servicios.Add(ser3);

            int cambiollantas = 0;
            string cod4 = "0004";
            float pre4 = 50000f;

            Servicio ser4 = new Servicio(cambiollantas, cod4, pre4); // Cambio de llantas
            servicios.Add(ser4);

            int pintura = 0;
            string cod5 = "0005";
            float pre5 = 200000f;

            Servicio ser5 = new Servicio(pintura, cod5, pre5); // Pintura
            servicios.Add(ser5);

            int reparacion_pieza_colision = 0;
            string cod6 = "0006";
            float pre6 = 250000f;

            Servicio ser6 = new Servicio(reparacion_pieza_colision, cod6, pre6); // Colisión de una pieza REPARACIÓN
            servicios.Add(ser6);

            int cambio_pieza_reparacion = 0;
            string cod7 = "0007";
            float pre7 = 250000f;

            Servicio ser7 = new Servicio(cambio_pieza_reparacion, cod7, pre7); // Colisión de una pieza CAMBIO
            servicios.Add(ser7);

            int cambio_luces = 0;
            string cod8 = "0008";
            float pre8 = 10000f;

            Servicio ser8 = new Servicio(cambio_luces, cod8, pre8);
            servicios.Add(ser8);

            int mant_sistema_electrico = 0;


        }

        */
    }
}
