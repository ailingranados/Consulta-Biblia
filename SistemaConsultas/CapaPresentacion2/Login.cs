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
            inicio form = new inicio();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

            textoUsuario.Text = "";
            textoPass.Text = "";

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
