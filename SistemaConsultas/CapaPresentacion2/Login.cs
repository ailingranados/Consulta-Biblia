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
            int Id_intentosUsuario;
            int Contador = 0;

            Id_intentosUsuario = InicioSesion.BuscarId_porCorreo(L_Correo.Text);

            SesionUsu = InicioSesion.Logear(L_Correo.Text, L_clave.Text);

            Contador = InicioSesion.Checar_intentos(Id_intentosUsuario);

            int Estado = InicioSesion.Estado_usuario(Id_intentosUsuario);

            if(Id_intentosUsuario == 0)
            {
                MessageBox.Show("Este usuario no existe", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(Estado == 2)
            {
                MessageBox.Show("No puede ingresar con este usuario porque esta dado de baja", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult salienda = MessageBox.Show("¿Desea reactivar su usuario?", ":o", MessageBoxButtons.YesNoCancel);

                if (salienda == DialogResult.Yes)
                {
                    Pregunta_secreta form = new Pregunta_secreta(Id_intentosUsuario);
                    form.Show();
                    this.Hide();
                    L_clave.Text = "";
                    L_Correo.Text = "";

                    form.FormClosing += frm_closing;

                }

                return;
            }
            
            
                if (SesionUsu.Rows.Count == 1)
                {
                    if (Contador == 3)
                    {
                        MessageBox.Show("Ha excedido la cantidad de intentos permitidos", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        InicioSesion.Editar_estadoBAJA(Id_intentosUsuario);

                        DialogResult salienda = MessageBox.Show("¿Desea reactivar su usuario?", ":o", MessageBoxButtons.YesNoCancel);

                        if (salienda == DialogResult.Yes)
                        {
                            Pregunta_secreta form = new Pregunta_secreta(Id_intentosUsuario);
                            form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                    
                            int id_usu;
                            int.TryParse(SesionUsu.Rows[0]["Id_usuario"].ToString(), out id_usu);

                            inicio form = new inicio(id_usu);

                            form.Show();
                            this.Hide();

                            form.FormClosing += frm_closing;

                            L_Correo.Text = "";
                            L_clave.Text = "";
                            InicioSesion.Intento_inicioSesionReiniciar(Id_intentosUsuario);


                    }
                }
                else
                {
                    InicioSesion.Intento_inicioSesion(Id_intentosUsuario);
                    MessageBox.Show("Usuario/contraseña incorrectos", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    L_clave.Text = "";
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
