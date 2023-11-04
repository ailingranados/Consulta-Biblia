using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Relaciones_UsuEst
    {
        public int Id_UsEst { get; set; }
        public string FechaReg { get; set; }
        public string FechaBaja { get; set; }
        public Usuario_estatus oUsuario_Estatus { get; set; }
        public Usuario_registros oUsuario_Registros { get; set; }

    }
}
