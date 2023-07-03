using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Planilla.Controllers
{
    internal class Conexion
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["BDSistemaPlanilla"].ToString());
        }
        public SqlConnection GetConnection(string Servidor)
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[Servidor].ToString());
        }
    }
}
