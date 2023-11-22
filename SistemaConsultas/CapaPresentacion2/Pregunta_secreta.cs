using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class Pregunta_secreta : Form
    {
        private static int usuarioActualId;
        public Pregunta_secreta(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void Pregunta_secreta_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //string respuesta = txt_respuesta.Text;

            EnlaceDB conexion = new EnlaceDB();
            // Obtén la fecha seleccionada del DateTimePicker
            DateTime fechaIngresada = NACIMIENTO.Value;


                // Ejecutar la consulta y obtener el resultado
            object resultado = conexion.FechaNacimientoPregunta(usuarioActualId);

            if (resultado != null && resultado != DBNull.Value)
            {
                if (resultado is DateTime)
                {
                    // Convertir el resultado a DateTime
                    DateTime fechaBaseDatos = (DateTime)resultado;

                    // Comparar las fechas
                    if (fechaIngresada.Date == fechaBaseDatos.Date)
                    {
                        MessageBox.Show("Las fechas son iguales.", "Comparación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (conexion.ActivarUsuarioViejo(usuarioActualId))
                        {
                            MessageBox.Show("Usuario reactivado. Se llevara a la pagina de cambio de contraseña", "Reactivación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CambioConActivacion form = new CambioConActivacion(usuarioActualId);
                            form.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las fechas no son iguales.", "Comparación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El valor obtenido no es de tipo DateTime.", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                    {
                        MessageBox.Show("No se encontró ninguna fecha en la base de datos.", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            

            //
        }
    }
}
