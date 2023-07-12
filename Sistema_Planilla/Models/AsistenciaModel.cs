using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_Planilla.Models
{
    class AsistenciaModel
    {

        public AsistenciaModel() { }

        public int Id_emp { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
      

        public static DataTable GetAsistencia { get; set; }

    }
}
