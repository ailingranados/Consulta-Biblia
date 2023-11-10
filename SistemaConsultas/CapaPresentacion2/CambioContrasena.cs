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

            bool Contraseña_cambiada = false;

            if(ValidarCampos())
            {
                int id_usu;
                int.TryParse(usuarioActual.Rows[0]["Id_usuario"].ToString(), out id_usu);

                string conVieja;
                conVieja = usuarioActual.Rows[0]["Clave"].ToString();

                Contraseña_cambiada = CambioCon.Editar_clave(id_usu, CC_con1.Text, conVieja);

                if (Contraseña_cambiada)
                {
                    MessageBox.Show("El usuario ha sido editado con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el usuario", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("No se pudo cambiar la contraseña, intentelo de nuevo", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

    }
}
