using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_Planilla.Models
{

    internal class ConseptosModel
    {
        public ConseptosModel() { }

        public int Id_conseptos { get; set; }
        public string Nombre_Cons { get; set; }
        public string Tipo_Cons { get; set; }
        public string TipodePersonal { get; set; }
        public float Precio { get; set; }
        public string Comentarios { get; set; }

        public static DataTable GetConceptos { get; set; }

    }
}
