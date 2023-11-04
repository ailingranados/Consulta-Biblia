using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Referencia_biblia
    {
        public int Id_referencia { get; set; }
        public int Id_Idioma { get; set; }
        public int Id_Version { get; set; }
        public int Id_Testamento { get; set; }
        public int Id_Libro { get; set; }
        public int Id_Versiculo { get; set; }
    }
}
