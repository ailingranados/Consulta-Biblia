using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class AgregarFavorito : Form
    {
        private static int usuarioActualId;
        private static DataTable DT_Biblia;

        private static int id_idioma;
        private static int id_version;
        private static int id_testamento;
        private static int id_libro;
        private static int id_versiculo;
        private static int id_capitulo;

        private static DataTable DT_consulta;


        //favoritos
        private static string STR_Idioma;
        private static string STR_Version;
        private static string STR_Testamento;
        private static string STR_Libro;
        private static int INT_Capitulo;
        private static int INT_Versiculo;
        private static String STR_Versiculo;
        public AgregarFavorito(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void AgregarFavorito_Load(object sender, EventArgs e)
        {
            Limpiar_campos();

            EnlaceDB EDB_ConsultarBiblia = new EnlaceDB();
            DT_Biblia = EDB_ConsultarBiblia.Consultar_Biblia();
            DGV_Favoritos.DataSource = DT_Biblia;
        }

        private void Limpiar_campos()
        {
            L_idioma.Text = "";
            L_version.Text = "";
            L_testamento.Text = "";
            L_libro.Text = "";
            L_capitulo.Text = "";
            L_versiculo.Text = "";
        }

        private void DGV_Favoritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpiar campos
            Limpiar_campos();

            L_idioma.Text = DGV_Favoritos.CurrentRow.Cells[0].Value.ToString();
            L_version.Text = DGV_Favoritos.CurrentRow.Cells[1].Value.ToString();
            L_testamento.Text = DGV_Favoritos.CurrentRow.Cells[2].Value.ToString();
            L_libro.Text = DGV_Favoritos.CurrentRow.Cells[3].Value.ToString();
            L_capitulo.Text = DGV_Favoritos.CurrentRow.Cells[4].Value.ToString();
            L_versiculo.Text = DGV_Favoritos.CurrentRow.Cells[5].Value.ToString();

            STR_Idioma = DGV_Favoritos.CurrentRow.Cells[0].Value.ToString();
            STR_Version = DGV_Favoritos.CurrentRow.Cells[1].Value.ToString();
            STR_Testamento = DGV_Favoritos.CurrentRow.Cells[2].Value.ToString();
            STR_Libro = DGV_Favoritos.CurrentRow.Cells[3].Value.ToString();
            //STR_Versiculo = DGV_Favoritos.CurrentRow.Cells[5].Value.ToString(); ;

            INT_Versiculo = int.Parse(DGV_Favoritos.CurrentRow.Cells[6].Value.ToString()); ;

            INT_Capitulo = int.Parse(DGV_Favoritos.CurrentRow.Cells[4].Value.ToString());
        }

        private void F_agregar_Click(object sender, EventArgs e)
        {
            EnlaceDB EDB_AgregarFavorito = new EnlaceDB();

            bool B_favorito = false;

            int INT_id_referencia;

            string NombreFav = Convert.ToString(F_nombre.Text);

            id_idioma = EDB_AgregarFavorito.Buscar_Idioma(STR_Idioma);

            id_version = EDB_AgregarFavorito.Buscar_Version(STR_Version);

            id_testamento = EDB_AgregarFavorito.Buscar_Testamento(STR_Testamento);

            id_libro = EDB_AgregarFavorito.Buscar_Libro(STR_Libro);

            id_versiculo = INT_Versiculo;

            id_capitulo = INT_Capitulo;

            if (RB_capitulo.Checked)
            {
                EDB_AgregarFavorito.Agregar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, 0);

                INT_id_referencia = EDB_AgregarFavorito.Buscar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, 0);

                B_favorito = EDB_AgregarFavorito.Agregar_fav(usuarioActualId, INT_id_referencia, NombreFav);

            }

            if (RB_versiculo.Checked)
            {
                EDB_AgregarFavorito.Agregar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, id_versiculo);

                INT_id_referencia = EDB_AgregarFavorito.Buscar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, id_versiculo);

                B_favorito = EDB_AgregarFavorito.Agregar_fav(usuarioActualId, INT_id_referencia, NombreFav);

            }

            if (B_favorito)
            {
                MessageBox.Show("Se ha agregado a favoritos con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido agregar :(", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
