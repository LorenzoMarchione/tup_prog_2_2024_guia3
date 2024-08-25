using Guia_3._4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Prestador medico1 = new Prestador("Javier");
            Prestador medico2 = new Prestador("Gonzalo");
            SinObra sinobra1 = new SinObra("15_23141123_6", "Renata", medico1);
            ObraSocial conobra1 = new ObraSocial("Juan", medico2);

            medico2.AgregarConsulta(sinobra1);
            lbListado.Items.Add($"Consulta de {sinobra1.ApellidosNombre}, monto = {sinobra1.PrestarServicio()}");
            medico2.AgregarConsulta(sinobra1);
            lbListado.Items.Add($"Consulta de {sinobra1.ApellidosNombre}, monto = {sinobra1.PrestarServicio()}");
            medico2.AgregarConsulta(sinobra1);
            lbListado.Items.Add($"Consulta de {sinobra1.ApellidosNombre}, monto = {sinobra1.PrestarServicio()}");
            medico2.AgregarConsulta(conobra1);
            lbListado.Items.Add($"Consulta de {conobra1.ApellidosNombre}, monto = {conobra1.PrestarServicio()}");
            medico1.AgregarConsulta(conobra1);
            lbListado.Items.Add($"Consulta de {conobra1.ApellidosNombre}, monto = {conobra1.PrestarServicio()}");
            medico1.AgregarConsulta(conobra1);
            lbListado.Items.Add($"Consulta de {conobra1.ApellidosNombre}, monto = {conobra1.PrestarServicio()}");

            lbListado.Items.Add($"Medico: {medico1.ApellidosNombre}, Monto a cobrar {medico1.GenerarPago()}");
            lbListado.Items.Add($"Medico: {medico2.ApellidosNombre}, Monto a cobrar {medico2.GenerarPago()}");

        }
    }
}

