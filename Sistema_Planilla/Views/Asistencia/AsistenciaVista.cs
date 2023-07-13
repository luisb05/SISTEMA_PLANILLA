using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Planilla.Models;
using Sistema_Planilla.Controllers;


namespace Sistema_Planilla.Views.Asistencia
{
    public partial class AsistenciaVista : Form
    {

        AsistenciaModel PAMO;
        public AsistenciaVista()
        {
            InitializeComponent();
           
        }

        void Salvar()
        {

            DateTime HoraSistema = DateTime.Now;
            TimeSpan HoraActual = HoraSistema.TimeOfDay;
            TimeSpan Entrada1 = new TimeSpan(21, 10, 00);
            TimeSpan Entrada2 = new TimeSpan(21, 15, 00);
            TimeSpan Salida1 = new TimeSpan(21, 18, 00);
            TimeSpan Salida2 = new TimeSpan(21, 25, 00);
         


            if (HoraActual > Entrada1 && HoraActual < Entrada2)
            {
                lblmensaje.Text = "Hora permitida por Recursos Humanos";

                PAMO = new AsistenciaModel();

                PAMO.Id_emp = int.Parse(txtcodigoEmpleado.Text);
                PAMO.Fecha = DateTime.Parse(lblfecharactual.Text);
                PAMO.FechaHoraEntrada = DateTime.Now;

                if (new AsistenciaControles().CrearAsistencia(PAMO) == true)
                {

                   MessageBox.Show("Ingresado Correctamente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error al Insertar Asistencia", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                lblmensaje.Text = "Hora no permitida por Recursos Humanos";
            }
            

             if (HoraActual > Salida1 && HoraActual < Salida2)
            {
                lblmensaje.Text = "Hora permitida por Recursos Humanos";

                PAMO = new AsistenciaModel();

                PAMO.Id_emp = int.Parse(txtcodigoEmpleado.Text);
                PAMO.Fecha = DateTime.Parse(lblfecharactual.Text);
                PAMO.FechaHoraSalida = DateTime.Now;

                if (new AsistenciaControles().ActualizarAsistencia2(PAMO) == true)
                {
                    MessageBox.Show("Datos actualizados Corectamente ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Error al Insertar Asistencia", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                lblmensaje.Text = "Hora no permitida por Recursos Humanos";
            }



        }

        private void AsistenciaVista_Load(object sender, EventArgs e)
        {
           

        }

        private void lblfecharactual_Click(object sender, EventArgs e)
        {
           
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblfecharactual.Text = DateTime.Now.ToShortDateString();
            lblhoraactual.Text = DateTime.Now.ToShortTimeString();
        }

        private void txtcodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
