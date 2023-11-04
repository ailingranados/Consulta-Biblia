using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consultas_consulta
    {
        public int Id_consulta { get; set; }
        public string Consulta { get; set; }
        public Referencia_biblia oReferencia_Biblia { get; set; }
    }
}
