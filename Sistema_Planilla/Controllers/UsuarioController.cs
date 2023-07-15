using Sistema_Planilla.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Planilla.Controllers
{
    internal class UsuarioController
    {
        public void ListarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "select * from Usuario";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 300;
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Con.Close();

                    UsuarioModel.GetUsuarios = dt;
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Informacion del Sistema");
            }

        }
    }
}
