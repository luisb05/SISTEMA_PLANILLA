using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Sistema_Planilla.Models;

namespace Sistema_Planilla.Controllers
{
    class AsistenciaControles
    {

        public bool CrearAsistencia(AsistenciaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "INSERT INTO [dbo].[Asistencias] (Id_emp, Fecha, FechaHoraEntrada) select " + Modelo.Id_emp + ", '" + Modelo.Fecha + "', '" + Modelo.FechaHoraEntrada + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();
                }


                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Informacion del Sistema");
                return false;
            }

        }


        public bool ActualizarAsistencia2(AsistenciaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "update Asistencias set FechaHoraSalida = '" + Modelo.FechaHoraSalida + "' where Id_emp = " + Modelo.Id_emp + " and Fecha = '" + Modelo.Fecha + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();
                }


                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Informacion del Sistema");
                return false;
            }

        }

    }
}
