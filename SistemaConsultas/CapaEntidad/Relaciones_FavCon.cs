using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Relaciones_FavCon
    {
        public int Id_FavCon { get; set; }
        public Consultas_favorito oConsultas_Favorito{ get; set; }

        public Consultas_consulta oConsultas_Consulta { get; set; }
    }
}
