using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class CambioConActivacion : Form
    {
        private static DataTable usuarioActual;
        private static DataTable contraseñasActuales;
        private static int usuarioActualId;
        public CambioConActivacion(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void CambioConActivacion_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (CC_con1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CC_con1, "Ingresar una contraseña");
            }

            if (CC_con2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CC_con2, "Ingresar una contraseña");
            }

            if (CC_con1.Text != CC_con2.Text)
            {
                ok = false;
                errorProvider1.SetError(CC_con1, "Ingresar una contraseña que coincida");
                errorProvider1.SetError(CC_con2, "Ingresar una contraseña que coincida");
            }
            if (CC_con1.Text.Length < 8)
            {
                ok = false;
                errorProvider1.SetError(CC_con1, "La contraseña debe tener al menos 8 caracteres");
            }

            if (CC_con2.Text.Length < 8)
            {
                ok = false;
                errorProvider1.SetError(CC_con2, "La contraseña debe tener al menos 8 caracteres");
            }

            if (!ValidarPassword(CC_con1.Text))
            {
                ok = false;
                errorProvider1.SetError(CC_con1, "La contraseña debe tener al menos una mayúscula, una minúscula y un carácter especial");
            }

            if (!ValidarPassword(CC_con2.Text))
            {
                ok = false;
                errorProvider1.SetError(CC_con2, "La contraseña debe tener al menos una mayúscula, una minúscula y un carácter especial");
            }

            return ok;
        }

        private bool ValidarPassword(string password)
        {
            // La expresión regular verifica que haya al menos una mayúscula, una minúscula y un carácter especial.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_]).*$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(password);
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            EnlaceDB CambioCon = new EnlaceDB();
            usuarioActual = CambioCon.Buscar_usu(usuarioActualId);

            EnlaceDB ConViejas = new EnlaceDB();
            contraseñasActuales = ConViejas.Buscar_ContraseñasViejas(usuarioActualId);

            bool Contraseña_cambiada = false;

            if (ValidarCampos())
            {
                bool SonIguales = false;
                string conAntigua1;
                string conAntigua2;
                string conVieja;
                string conNueva;
                int id_usu;

                int.TryParse(usuarioActual.Rows[0]["Id_usuario"].ToString(), out id_usu);

                conVieja = usuarioActual.Rows[0]["Clave"].ToString();

                conNueva = CC_con1.Text;

                conAntigua1 = contraseñasActuales.Rows[0]["ConVieja1"].ToString();

                conAntigua2 = contraseñasActuales.Rows[0]["ConVieja2"].ToString();

                if (Equals(conAntigua1, conNueva))
                {
                    SonIguales = true;
                }
                if (Equals(conAntigua2, conNueva))
                {
                    SonIguales = true;
                }
                if (Equals(conVieja, conNueva))
                {
                    SonIguales = true;
                }

                if (SonIguales)
                {
                    MessageBox.Show("La nueva contraseña coincide con otra contraseña utilizada anteriormente", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Contraseña_cambiada = CambioCon.Editar_clave(id_usu, CC_con1.Text, conVieja);

                    if (Contraseña_cambiada)
                    {
                        MessageBox.Show("La contraseña ha sido editado con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CambioCon.Intento_inicioSesionReiniciar(id_usu);
                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña coincide con una contraseña vieja", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }



            }
            else
            {
                MessageBox.Show("No se pudo cambiar la contraseña, cheque los campos", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CC_con1.Text = "";
                CC_con2.Text = "";
            }

        }
    }
}
