using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario_contraseña
    {
        public int Id_contraseña { get; set; }

        public string ConVieja1 { get; set; }
        public string ConVieja2 { get; set; }
        public Usuario_registros oUsuario_registros { get; set; }

    }
}
