using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaBiblia;
using CapaEntidad;

namespace CapaPresentacion2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<Usuario_registros> TEST = new CB_Usuario_registro().Listar();

            Usuario_registros ousuario = new CB_Usuario_registro().Listar().Where(u => u.Correo == txtCorreo.Text && u.Clave == txtContraseña.Text).FirstOrDefault();
            
            if(ousuario != null)
            {
                inicio form = new inicio();

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

                txtCorreo.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {


            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
