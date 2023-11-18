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
            EnlaceDB InicioSesion = new EnlaceDB();

            DataTable SesionUsu = new DataTable();

            SesionUsu = InicioSesion.Logear(L_Correo.Text, L_clave.Text);

            if(SesionUsu.Rows.Count == 1)
            {
                int id_usu;
                int.TryParse(SesionUsu.Rows[0]["Id_usuario"].ToString(), out id_usu);

                inicio form = new inicio(id_usu);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

                L_Correo.Text = "";
                L_clave.Text = "";
            }
            
            else
            {
                MessageBox.Show("Usuario/contraseña incorrectos", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {


            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Registrarse form = new Registrarse();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }
    }
}
