using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaBiblia
{
    public class CB_Usuario_registro
    {
        private CD_Usuarios_registros objcd_usuario_registro = new CD_Usuarios_registros();

        public List<Usuario_registros> Listar()
        { 

            return objcd_usuario_registro.Listar();
        }

        }
}
