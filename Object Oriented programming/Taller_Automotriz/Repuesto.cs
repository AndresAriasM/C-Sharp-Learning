using System;
using System.Collections.Generic;
using System.Text;

namespace TallerAutomotriz_Final
{
    class Repuesto
    {
        private string nombre_repuesto;
        private float cantidad_repuesto;
        private string codigo_repuesto;
        private float valor_repuesto;

        public Repuesto(string nombre_repuesto, float cantidad_repuesto, string codigo_repuesto, float valor_repuesto)
        {
            this.Nombre_repuesto = nombre_repuesto;
            this.Cantidad_repuesto = cantidad_repuesto;
            this.Codigo_repuesto = codigo_repuesto;
            this.valor_repuesto = valor_repuesto;
        }

        public string Nombre_repuesto { get => nombre_repuesto; set => nombre_repuesto = value; }
        public float Cantidad_repuesto { get => cantidad_repuesto; set => cantidad_repuesto = value; }
        public string Codigo_repuesto { get => codigo_repuesto; set => codigo_repuesto = value; }
        public float Valor_repuesto { get => valor_repuesto; set => valor_repuesto = value; }

        public virtual void AñadirNuevoRepuesto(string nuevo_repuesto, int cant, string cod, float val, List<Repuesto> repuestos)
        {
            if (nuevo_repuesto != null)
            {
                Repuesto rep1 = new Repuesto(nuevo_repuesto, cant, cod, val);
                repuestos.Add(rep1);
            }
        }

        public virtual void EliminarRepuesto(List<Repuesto> repuestos, string codi)
        {
            if (repuestos.Exists(x => x.Codigo_repuesto == codi))
            {
                Repuesto r1;
                r1 = repuestos.Find(x => x.Codigo_repuesto == codi);
                
                repuestos.Remove(r1);
            }
        }

        public virtual void ModificarRepuestoAumentar(float cant, string codi, List<Repuesto> repuestos)
        {
            
            if(repuestos.Exists(x => x.Codigo_repuesto == codi))
            {
                Repuesto r1 = repuestos.Find(x => x.Codigo_repuesto == codi);
                r1.Cantidad_repuesto += cant;

                r1 = new Repuesto(r1.Nombre_repuesto, cant, codi, r1.Valor_repuesto);
                repuestos.Add(r1);
            }
        }

        public virtual void ModificarRepuestoReducir(float cant, string codi, List<Repuesto> repuestos)
        {
            if (repuestos.Exists(x => x.Codigo_repuesto == codi))
            {
                Repuesto r1 = repuestos.Find(x => x.Codigo_repuesto == codi);
                r1.Cantidad_repuesto -= cant;

                repuestos.Add(r1);
            }
        }
    }
}
