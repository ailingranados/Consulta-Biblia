using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class Favoritos : Form
    {
        private static int usuarioActualId;
        private static DataTable DT_favoritos;
        private static DataTable DT_biblia;
        
        public Favoritos(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            EnlaceDB EDB_Favoritos = new EnlaceDB();
            int INT_referencia;


            DT_favoritos = EDB_Favoritos.tabla_favoritos(usuarioActualId);

            DGV_Favoritos.DataSource = DT_favoritos;

        }
    }
}
