using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Planilla.Models
{
    internal class EmpleadoModel
    {
        public EmpleadoModel() { }

        public int id_emp { get; set; }

        public string emp_Codigo { get; set; }

        public string emp_Nombres { get; set;}

        public string emp_Apellidos { get; set; }

        public string emp_Identificacion { get; set; }

        public string emp_Telefono { get; set; }

        public string emp_Correoelectronico { get; set; }

        public int emp_Departamento_Id { get; set; }

        public int emp_Puesto_Id { get; set; }

        public DateTime emp_FechaIngreso { get; set; }

        public string emp_Direccion { get; set; }

        public bool emp_Estado { get; set; }

        public static DataTable GetEmpleados { get; set; }
    }
}
