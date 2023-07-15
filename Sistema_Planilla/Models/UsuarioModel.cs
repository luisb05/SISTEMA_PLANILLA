using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Planilla.Models
{
    internal class UsuarioModel
    {
        public UsuarioModel() { }

        public int id_Usu { get; set; }

        public string usu_UsuarioLogin { get; set; }

        public string usu_Constrasena { get; set; }

        public string usu_Nombres { get; set; }

        public string usu_Apellidos { get; set; }

        public string usu_Correo { get; set; }

        public DateTime usu_FechaCreacion { get; set; }

        public bool usu_Estado { get; set; }

        public bool usu_EsAdministrador { get; set; }

        public static DataTable GetUsuarios { get; set; }
    }
}
