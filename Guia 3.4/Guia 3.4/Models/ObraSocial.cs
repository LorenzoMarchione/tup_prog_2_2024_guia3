using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._4.Models
{
    class ObraSocial:Prestacion
    {
        public double arancel = 200;
        private int consultasMensuales = 0;
        public int ConsultasMensuales { get { return consultasMensuales; } private set { consultasMensuales=value; } }
       
        public ObraSocial (string nombre, Prestador medico):base(nombre,medico) 
        {
            ApellidosNombre = nombre;
            base.medico = medico;
        }

        public override double PrestarServicio()
        {
            ConsultasMensuales++;
            if (ConsultasMensuales > 2)
            {
                return arancel;
            }
            else { return 0; }
        }
    }
}
