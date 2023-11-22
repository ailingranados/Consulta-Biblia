using FontAwesome.Sharp;
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
    public partial class inicio : Form
    {
        private static DataTable usuarioActual;
        private static int usuarioActualId;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public inicio(int id_usu)
        {
            usuarioActualId = id_usu;

            InitializeComponent();
        }

        public void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null) 
            { 
                MenuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Transparent;

            panel1.Controls.Add(formulario);
            formulario.Show();

        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new Usuario(usuarioActualId));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
            EnlaceDB BuscarUsu = new EnlaceDB();
            usuarioActual = BuscarUsu.Buscar_usu(usuarioActualId);

            labelUsuario.Text = usuarioActual.Rows[0]["Nombre"].ToString();

        }

        private void menuFavorito_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Favoritos(usuarioActualId));
        }

        private void menuHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Historial(usuarioActualId));
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new Consulta_IdiomaVersion(usuarioActualId));
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Busqueda(usuarioActualId));
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            DialogResult salienda = MessageBox.Show("¿Desea cerrar sesion?", "Adios", MessageBoxButtons.YesNoCancel);

            if (salienda == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AcercaDe());
        }
    }
}
