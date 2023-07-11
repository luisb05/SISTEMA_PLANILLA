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
    internal class ConseptosControles
    {
        public bool CrearConcepto(ConseptosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "INSERT INTO [dbo].[Conseptos](Id_conseptos,Nombre_Cons,Tipo_Cons,TipodePersonal,Precio,Comentarios) select " + Modelo.Id_conseptos + ",'" + Modelo.Nombre_Cons + "','" + Modelo.Tipo_Cons + "','" + Modelo.TipodePersonal + "','" + Modelo.Precio + "','" + Modelo.Comentarios + "'";

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

        public void ListarConceptos()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "select *from Conseptos";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 300;
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Con.Close();

                    ConseptosModel.GetConceptos = dt;
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Informacion del Sistema");
            }

        }

        public bool ActualizarConceptos(ConseptosModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "update Conseptos set Nombre_Cons = '" + Modelo.Nombre_Cons + "',Tipo_Cons = '" + Modelo.Tipo_Cons + "',TipodePersonal = '" + Modelo.TipodePersonal + "',Precio = '" + Modelo.Precio + "',Comentarios = '" + Modelo.Comentarios + "' where Id_conseptos = " + Modelo.Id_conseptos;

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

        public bool EliminarConceptos(ConseptosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection("BDSistemaPlanilla"))
                {
                    Con.Open();

                    string sql = "delete Conseptos where Id_conseptos = '" + Modelo.Id_conseptos + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                return false;
            }

        }


    }
}
