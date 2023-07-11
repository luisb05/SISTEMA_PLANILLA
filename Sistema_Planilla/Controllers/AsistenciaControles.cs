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

                    string sql = "INSERT INTO [dbo].[Asistencias] (Id_emp, FechaHoraEntrada) select " + Modelo.Id_emp + ", '" + Modelo.FechaHoraEntrada + "'";

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


        public bool CrearAsistencia2(AsistenciaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "INSERT INTO [dbo].[Asistencias] (Id_emp, FechaHoraSalida) select " + Modelo.Id_emp + ", '" + Modelo.FechaHoraSalida + "'";

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
