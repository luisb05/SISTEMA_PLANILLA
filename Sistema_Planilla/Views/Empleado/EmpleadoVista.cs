using Sistema_Planilla.Controllers;
using Sistema_Planilla.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Planilla.Views.Empleado
{
    public partial class EmpleadoVista : Form
    {
        string Modo;
        public EmpleadoVista()
        {
            InitializeComponent();
            Modo = "Agregando";
            lblmodo.Text = Modo;
        }

        void ListasEmpleados()
        {

            new EmpleadoController().ListarEmpleados();
            dgvUbicardatos.DataSource = EmpleadoModel.GetEmpleados;

        }
        private void EmpleadoVista_Load(object sender, EventArgs e)
        {
            ListasEmpleados();
        }
    }
}
