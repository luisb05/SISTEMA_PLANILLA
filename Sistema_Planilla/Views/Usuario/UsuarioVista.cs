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

namespace Sistema_Planilla.Views.Usuario
{
    public partial class UsuarioVista : Form
    {
        string Modo;
        public UsuarioVista()
        {
            InitializeComponent();
            Modo = "Agregando";
            lblmodo.Text = Modo;
        }

        void ListasUsuario()
        {

            new UsuarioController().ListarUsuarios();
            dgvUbicardatos.DataSource = UsuarioModel.GetUsuarios;

        }

        private void UsuarioVista_Load(object sender, EventArgs e)
        {
            ListasUsuario();
        }
    }
}
