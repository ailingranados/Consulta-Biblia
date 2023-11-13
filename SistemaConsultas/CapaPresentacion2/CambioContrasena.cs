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
    public partial class CambioContrasena : Form
    {
        private static DataTable usuarioActual;
        private static DataTable contraseñasActuales;
        private static int usuarioActualId;
        public CambioContrasena(int id_usu)
        {
            usuarioActualId = id_usu;

            InitializeComponent();
        }

        private void CambioContrasena_Load(object sender, EventArgs e)
        {
            
           
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {//cambiar contraseña
            EnlaceDB CambioCon = new EnlaceDB();
            usuarioActual = CambioCon.Buscar_usu(usuarioActualId);

            EnlaceDB ConViejas = new EnlaceDB();
            contraseñasActuales = ConViejas.Buscar_ContraseñasViejas(usuarioActualId);

            bool Contraseña_cambiada = false;

            if(ValidarCampos())
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

            }

            
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


            return ok;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
