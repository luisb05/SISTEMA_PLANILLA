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

namespace Sistema_Planilla.Views.Asistencia_Cons_Horas
{
    public partial class ConseptosVista : Form
    {
        ConseptosModel PAMO;
        string Modo;
        ConseptosModel Modelo;

        public ConseptosVista()
        {
            InitializeComponent();
            Modo = "Agregando";
            lblmodo.Text = Modo;

        }

        void Salvar()
        {

            PAMO = new ConseptosModel();

            PAMO.Id_conseptos = int.Parse(txtidconcepto.Text);
            PAMO.Nombre_Cons = txtNombre.Text;
            PAMO.Tipo_Cons = cbxtipoconcepto.Text;
            PAMO.TipodePersonal =cbxaplia.Text;
            PAMO.Precio = float.Parse(txtprecio.Text);
            PAMO.Comentarios = txtcomentario.Text;

            if (lblmodo.Text == "Agregando")
            {
                if (new ConseptosControles().CrearConcepto(PAMO) == true)
                {
                    MessageBox.Show("Concepto Insertado Exitosamente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListasConceptos();
                    cancelar();
                }

                else
                    MessageBox.Show("Error al Insertar Concepto", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                


                if (new ConseptosControles().ActualizarConceptos(PAMO) == true)
                {
                    MessageBox.Show("Conceptos Actualizado Exitosamente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListasConceptos();
                    cancelar();
                    lblmodo.Text = "Agregando";
                    txtidconcepto.Enabled = true;

                }

                else
                    MessageBox.Show("Error al Actualizar Conceptos", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new ConseptosModel();

                Modelo.Id_conseptos = int.Parse(dgvUbicardatos.SelectedCells[0].Value.ToString());

                if (new ConseptosControles().EliminarConceptos(Modelo) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    ListasConceptos();
                }
            }
            btneliminar.Enabled = false;
        }

        void cancelar()
        {
            txtidconcepto.Clear();
            txtNombre.Clear();
            txtprecio.Clear();
            txtcomentario.Clear();

            txtidconcepto.Focus();

        }

        void Filtar()
        {

            ConseptosModel.GetConceptos.DefaultView.RowFilter = $"Id_conseptos+Nombre_Cons+Tipo_Cons+TipodePersonal+Precio+Comentarios like '%{txtubicar.Text}%'";

        }

        void ListasConceptos()
        {

            new ConseptosControles().ListarConceptos();
            dgvUbicardatos.DataSource = ConseptosModel.GetConceptos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void ConseptosVista_Load(object sender, EventArgs e)
        {
            ListasConceptos();
        }

        private void dgvUbicardatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtidconcepto.Text = dgvUbicardatos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUbicardatos.CurrentRow.Cells[1].Value.ToString();
            cbxtipoconcepto.Text = dgvUbicardatos.CurrentRow.Cells[2].Value.ToString();
            cbxaplia.Text = dgvUbicardatos.CurrentRow.Cells[3].Value.ToString();
            txtprecio.Text = dgvUbicardatos.CurrentRow.Cells[4].Value.ToString();
            txtcomentario.Text = dgvUbicardatos.CurrentRow.Cells[5].Value.ToString();

            lblmodo.Text = "Edicion";

            txtidconcepto.Enabled = false;
            txtNombre.Focus();
        }

        private void dgvUbicardatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btneliminar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void txtubicar_TextChanged(object sender, EventArgs e)
        {
            Filtar();
        }
    }
}
