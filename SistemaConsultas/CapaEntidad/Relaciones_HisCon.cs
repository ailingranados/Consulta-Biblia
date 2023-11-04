using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Relaciones_HisCon
    {
        public int Id_HisCon { get; set; }
        public Consultas_historial oConsultas_Historial { get; set; }

        public Consultas_consulta oConsultas_Consulta { get; set; }
    }
}
