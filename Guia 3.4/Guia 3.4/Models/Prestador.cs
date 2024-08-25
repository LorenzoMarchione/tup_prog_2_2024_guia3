using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._4.Models
{
    class Prestador:Persona
    {
        private ArrayList consultas = new ArrayList();
        public Prestador(string nombre) : base(nombre)
        {
            ApellidosNombre = nombre;
        }

        public void AgregarConsulta (Prestacion consulta)
        {
            consultas.Add(consulta);
        }
        public double GenerarPago()
        {
            double cobro = 300 * consultas.Count;
            return cobro;
        }
    }
}
