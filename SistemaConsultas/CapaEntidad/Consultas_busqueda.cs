using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consultas_busqueda
    {
        public int Id_busqueda { get; set; }
        public string Texto { get; set; }
        public string Fecha { get; set; }
        public Usuario_registros oUsuario_Registros { get; set; }
        public Referencia_biblia oReferencia_Biblia { get; set; }
    }
}
