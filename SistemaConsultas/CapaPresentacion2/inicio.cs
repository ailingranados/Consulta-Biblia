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

using CapaEntidad;


namespace CapaPresentacion2
{
    public partial class inicio : Form
    {
        private static Usuario_registros usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public inicio(Usuario_registros objUsuario)
        {
            usuarioActual = objUsuario;

            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
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
            formulario.BackColor = Color.RosyBrown;

            panel1.Controls.Add(formulario);
            formulario.Show();

        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new Usuario());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = usuarioActual.Nombre;
        }

        private void menuFavorito_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Favoritos());
        }

        private void menuHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Historial());
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Consulta());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Busqueda());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AcercaDe());
        }
    }
}
