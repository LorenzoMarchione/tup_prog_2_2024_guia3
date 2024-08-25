using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._4.Models
{
    class SinObra:Prestacion
    {
        public string CUIT;
        public double importeFijo = 250;
        
        public SinObra (string CUIT, string nombre, Prestador medico): base(nombre, medico)
        {
            this.CUIT = CUIT;
            ApellidosNombre = nombre;
            base.medico = medico;
        }

        public override double PrestarServicio()
        {
            return importeFijo;
        }
    }
}
