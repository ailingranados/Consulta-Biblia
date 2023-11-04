using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consultas_favorito
    {
        public int Id_favorito { get; set; }
        public Usuario_registros oUsuario_Registros { get; set; }
        public string FechaFav { get; set; }
        public Referencia_biblia oReferencia_Biblia { get; set; }
    }
}
