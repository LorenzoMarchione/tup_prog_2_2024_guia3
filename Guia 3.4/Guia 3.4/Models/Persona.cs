using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._4.Models
{
    abstract class Persona
    {
        public string ApellidosNombre;

        public Persona (string Nombres)
        {
            ApellidosNombre = Nombres;
        }
    }
}
