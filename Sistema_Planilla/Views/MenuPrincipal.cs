using Sistema_Planilla.Views.Asistencia;
using Sistema_Planilla.Views.Concepto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Planilla.Views
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConcepto_Click(object sender, EventArgs e)
        {
            ConseptosVista formArticulos = new ConseptosVista();
            formArticulos.ShowDialog();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            AsistenciaVista formArticulos = new AsistenciaVista();
            formArticulos.ShowDialog();
        }
    }
}
