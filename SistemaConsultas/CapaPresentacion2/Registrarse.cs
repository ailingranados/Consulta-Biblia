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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {//aceptar_registro

            int genero = 3;

            if(genero_F.Checked)
            {
                genero = 1;
            }

            if (genero_M.Checked)
            {
                genero = 2;
            }

            EnlaceDB Registrado = new EnlaceDB();

            string fecha_nac = Convert.ToString(NACIMIENTO.Text);

            Registrado.Agregar_usuario(genero, R_correo.Text, fecha_nac, R_nombre.Text, R_apM.Text, R_apP.Text, R_clave.Text);

    

            Login form = new Login();

            form.Show();
            this.Hide();



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void NACIMIENTO_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
