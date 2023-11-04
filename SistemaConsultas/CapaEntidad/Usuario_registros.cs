using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario_registros
    {
        public int Id_usuario { get; set; }

        public Usuario_genero oUsuario_genero { get; set; }
        public string Correo { get; set; }
        public string Fecha_nac { get; set; }
        public string Nombre { get; set; }
        public string ApellidoM { get; set; }
        public string ApellidoP { get; set; }

    }
}
