using Sistema_Planilla.Views.Asistencia;
using Sistema_Planilla.Views.Concepto;
using Sistema_Planilla.Views.Empleado;
using Sistema_Planilla.Views.Usuario;
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
            ConseptosVista frm = (ConseptosVista)Application.OpenForms["ConseptosVista"];
            if (frm == null)
            {
                frm = new ConseptosVista();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            AsistenciaVista frm = (AsistenciaVista)Application.OpenForms["AsistenciaVista"];
            if (frm == null)
            {
                frm = new AsistenciaVista();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoVista frm = (EmpleadoVista)Application.OpenForms["EmpleadoVista"];
            if (frm == null)
            {
                frm = new EmpleadoVista();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            UsuarioVista frm = (UsuarioVista)Application.OpenForms["UsuarioVista"];
            if (frm == null)
            {
                frm = new UsuarioVista();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
    }
}
