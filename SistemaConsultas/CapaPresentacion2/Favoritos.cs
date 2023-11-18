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
    public partial class Favoritos : Form
    {
        private static int usuarioActualId;
        private static DataTable DT_favoritos;
        private static DataTable DT_versiculos;
        StringBuilder sb = new StringBuilder();

        public Favoritos(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            Limpiar_campos();


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //limpiar campos
            Limpiar_campos();

            EnlaceDB EDB_Favoritos = new EnlaceDB();
            int INT_referencia;

            DT_favoritos = EDB_Favoritos.tabla_favoritos(usuarioActualId);

            DGV_Favoritos.DataSource = DT_favoritos;

            DT_versiculos = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //limpiar campos
            Limpiar_campos();

            EnlaceDB EDB_Favoritos = new EnlaceDB();
            int INT_referencia;

            DT_favoritos = EDB_Favoritos.tabla_favoritosCapitulos(usuarioActualId);

            DGV_Favoritos.DataSource = DT_favoritos;

            DGV_Favoritos.Columns[8].Visible = false;
            DGV_Favoritos.Columns[9].Visible = false;
            DGV_Favoritos.Columns[10].Visible = false;
            DGV_Favoritos.Columns[11].Visible = false;
            DGV_Favoritos.Columns[12].Visible = false;
            DGV_Favoritos.Columns[13].Visible = false;
            DGV_Favoritos.Columns[14].Visible = false;

            int capitulo = int.Parse(DGV_Favoritos.CurrentRow.Cells[6].Value.ToString());

            DT_versiculos = EDB_Favoritos.VersiculosEnCapitulo(capitulo);


        }

        private void DGV_Favoritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpiar campos
            Limpiar_campos();

            L_idioma.Text = DGV_Favoritos.CurrentRow.Cells[2].Value.ToString();
            L_version.Text = DGV_Favoritos.CurrentRow.Cells[3].Value.ToString();
            L_testamento.Text = DGV_Favoritos.CurrentRow.Cells[4].Value.ToString();
            L_libro.Text = DGV_Favoritos.CurrentRow.Cells[5].Value.ToString();
            L_capitulo.Text = DGV_Favoritos.CurrentRow.Cells[6].Value.ToString();
            L_versiculo.Text = DGV_Favoritos.CurrentRow.Cells[7].Value.ToString();

            if (DT_versiculos != null)
            {
                L_versiculo.Text = "";
                int lineNumber = 1; 

                foreach (DataRow row in DT_versiculos.Rows)
                {
                    sb.AppendLine($"{lineNumber}. {row[0].ToString()}"); // Agrega el número de línea seguido del valor
                    lineNumber++;
                }

                L_versiculo.Multiline = true;
                L_versiculo.Text = sb.ToString();
            }
         

          

        }

        private void Limpiar_campos()
        {
            L_idioma.Text = "";
            L_version.Text = "";
            L_testamento.Text = "";
            L_libro.Text = "";
            L_capitulo.Text = "";
            L_versiculo.Text = "";
            sb.Clear();
        }

        private void F_usuario_Click(object sender, EventArgs e)
        {
            AgregarFavorito form = new AgregarFavorito(usuarioActualId);

            form.Show();
            this.Hide();
        }

        private void F_eliminar_Click(object sender, EventArgs e)
        {


            DialogResult salienda = MessageBox.Show("¿Desea eliminar el favorito?", ":(", MessageBoxButtons.YesNoCancel);

            if (salienda == DialogResult.Yes)
            {
                EnlaceDB EDB_EliminarFavorito = new EnlaceDB();

                int INT_favorito = int.Parse(DGV_Favoritos.CurrentRow.Cells[8].Value.ToString());
                bool Baja = false;

                Baja = EDB_EliminarFavorito.Eliminar_fav(INT_favorito);

                if (Baja)
                {
                    MessageBox.Show("Se ha eliminado el favorito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el favorito, intente de nuevo", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
