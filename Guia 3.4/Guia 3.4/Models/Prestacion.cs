using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._4.Models
{
    abstract class Prestacion:Persona
    {
        private double montoTotal;
        public double MontoTotal { get {  return montoTotal; } private set {  montoTotal = value; } }
        protected Prestador medico;

        public Prestacion(string Nombres, Prestador medico): base(Nombres) 
        {
            ApellidosNombre = Nombres;
            this.medico = medico;

        }
        abstract public double PrestarServicio();
    }
}
