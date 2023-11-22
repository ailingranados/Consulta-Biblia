using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class Usuario : Form
    {
        private static DataTable usuarioActual;
        private static int usuarioActualId;
        
        private static bool correcto1 = true;
        private static bool correcto2 = true;
        private static bool correcto3 = true;
        public Usuario(int id_usu)
        {
            usuarioActualId = id_usu;
            

            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            EnlaceDB BuscarUsu = new EnlaceDB();
            usuarioActual = BuscarUsu.Buscar_usu(usuarioActualId);

            string Id_genero = usuarioActual.Rows[0]["Id_Genero"].ToString();
            string genero;

            switch (Id_genero)
            {
                case "1":
                    genero = "Femenino";
                    break;
                case "2":
                    genero = "Masculino";
                    break;
                case "3":
                    genero = "Sin Especificar";
                    break;
                default:
                    genero = "Sin Especificar";
                    break;
            }

            
            U_correo.Text = usuarioActual.Rows[0]["Correo"].ToString();
            U_FechaN.Text = usuarioActual.Rows[0]["Fecha_nac"].ToString();
            U_Genero.Text = genero.ToString();

            U_nombre.Text = usuarioActual.Rows[0]["Nombre"].ToString();
            U_apellidoP.Text = usuarioActual.Rows[0]["ApellidoP"].ToString();
            U_apellidoM.Text = usuarioActual.Rows[0]["ApellidoM"].ToString();
            U_clave.Text = usuarioActual.Rows[0]["Clave"].ToString();



        }

        private void EditarUsuario_Click(object sender, EventArgs e)
        {
            if (correcto1 == false | correcto2 == false | correcto3 == false)
            {
                MessageBox.Show("No se pudo registrar el usuario, cheque los campos con error", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
                EnlaceDB EditarUsuario = new EnlaceDB();

                usuarioActual = EditarUsuario.Buscar_usu(usuarioActualId);

                bool UsuarioEditado = false;

                int id_usu;
                int.TryParse(usuarioActual.Rows[0]["Id_usuario"].ToString(), out id_usu);


                UsuarioEditado = EditarUsuario.Editar_usuario(id_usu, U_nombre.Text, U_apellidoM.Text, U_apellidoP.Text);

                if (UsuarioEditado)
                {
                    MessageBox.Show("El usuario ha sido editado con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo editar el usuario", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                this.Close();


            
            

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CambioContrasena form = new CambioContrasena(usuarioActualId);

            form.Show();
            this.Hide();

        }

        private void U_baja_Click(object sender, EventArgs e)
        {
            DialogResult salienda = MessageBox.Show("¿desea desactivar su usuario?" , ":((((((((", MessageBoxButtons.YesNoCancel);
            
            if (salienda == DialogResult.Yes)
            {
                EnlaceDB EDB_BAJA = new EnlaceDB();

                bool Baja = false;

                Baja = EDB_BAJA.Editar_estadoBAJA(usuarioActualId);

                if (Baja)
                {
                    MessageBox.Show("El usuario ha sido dado de baja con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Form inicioForm = Application.OpenForms.OfType<inicio>().FirstOrDefault();
                    inicioForm?.Close();

                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja al usuario", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

          

        }

        private void U_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void U_nombre_Validating(object sender, CancelEventArgs e)
        {
            string apellidoM = U_nombre.Text;
            Regex regex = new Regex("^[\\p{L}]+$");

            if (!regex.IsMatch(apellidoM))
            {
                errorProvider1.SetError(U_nombre, "El nombre solo debe contener letras.");
                correcto1  = false;
            }
            else
            {
                errorProvider1.SetError(U_nombre, "");
                correcto1 = true;
            }
        }

        private void U_apellidoP_Validating(object sender, CancelEventArgs e)
        {
            string apellidoM = U_apellidoP.Text;
            Regex regex = new Regex("^[\\p{L}]+$");

            if (!regex.IsMatch(apellidoM))
            {
                errorProvider1.SetError(U_apellidoP, "El nombre solo debe contener letras.");
                correcto2 = false;
            }
            else
            {
                errorProvider1.SetError(U_apellidoP, "");
                correcto2 = true;
            }
        }

        private void U_apellidoM_Validating(object sender, CancelEventArgs e)
        {
            string apellidoM = U_apellidoM.Text;
            Regex regex = new Regex("^[\\p{L}]+$");

            if (!regex.IsMatch(apellidoM))
            {
                errorProvider1.SetError(U_apellidoM, "El nombre solo debe contener letras.");
                correcto3 = false;
            }
            else
            {
                errorProvider1.SetError(U_apellidoM, "");
                correcto3 = true;
            }
        }
    }
}
