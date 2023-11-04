using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consultas_historial
    {
        public int Id_historial { get; set; }
        public string Texto { get; set; }
        public Consultas_busqueda oConsultas_Busqueda { get; set; }
        public string FechaBus { get; set; }
        public Referencia_biblia oReferencia_Biblia { get; set; }
    }
}
