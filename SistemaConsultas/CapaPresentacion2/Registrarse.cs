﻿using System;
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
            BorrarMensajeError();
            
            if (ValidarCampos())
            {
                //saber el numero que vamos a mandar a genero
                int genero = 3;// el numero 3 significa "Sin Especificar"

                if (genero_F.Checked)
                {
                    genero = 1;
                }

                if (genero_M.Checked)
                {
                    genero = 2;
                }

                //hablar a el sp en agregar usuario
                EnlaceDB Registrado = new EnlaceDB();

                string fecha_nac = Convert.ToString(NACIMIENTO.Text);

                bool SeRegistro = false;

                SeRegistro = Registrado.Agregar_usuario(genero, R_correo.Text, fecha_nac, R_nombre.Text, R_apM.Text, R_apP.Text, R_clave.Text);

                
                //si se registra, devuelve verdadero y podemos seguir
                if (SeRegistro)
                {
                    
                    MessageBox.Show("Se registro su usuario correctamente", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login form = new Login();

                    form.Show();
                    this.Hide();
                }
                //si no se registra manda error
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario, cheque los campos con error", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //validar que los campos no esten vacios
        private bool ValidarCampos()
        {
            bool ok = true;

            if(R_correo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(R_correo, "Ingresar un correo");
            }

            if (R_clave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(R_clave, "Ingresar una contraseña");
            }

            if (NACIMIENTO.Text == "")
            {
                ok = false;
                errorProvider1.SetError(NACIMIENTO, "Ingresar una fecha de nacimiento");
            }

            if (R_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(R_nombre, "Ingresar un nombre");
            }

            if (R_apP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(R_apP, "Ingresar un apellido paterno");
            }

            if (R_apM.Text == "")
            {
                ok = false;
                errorProvider1.SetError(R_apM, "Ingresar un apellido materno");
            }

            //solo se elige uno pero se hace la funcion por si ocurre algun error
            if ((genero_F.Checked & genero_M.Checked) | 
                (genero_F.Checked & genero_default.Checked) | 
                (genero_M.Checked & genero_default.Checked) | 
                (genero_F.Checked & genero_default.Checked & genero_M.Checked))
            {
                ok = false;
                errorProvider1.SetError(genero_default, "Ingresar solo un genero");

            }


            return ok;
        }

        //limpiar errores
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(R_correo, "");
            errorProvider1.SetError(R_clave, "");
            errorProvider1.SetError(NACIMIENTO, "");
            errorProvider1.SetError(genero_default, "");
            errorProvider1.SetError(R_nombre, "");
            errorProvider1.SetError(R_apP, "");
            errorProvider1.SetError(R_apM, "");
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

        private void R_clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_clave_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void R_nombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = R_nombre.Text;
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(nombre))
            {
                errorProvider1.SetError(R_nombre, "El nombre solo debe contener letras.");
            }
            else
            {
                errorProvider1.SetError(R_nombre, "");

            }
        }

        private void R_apP_Validating(object sender, CancelEventArgs e)
        {
            string apellidoP = R_apP.Text;
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(apellidoP))
            {
                errorProvider1.SetError(R_apP, "El nombre solo debe contener letras.");
            }
            else
            {
                errorProvider1.SetError(R_apP, "");

            }
        }

        private void R_apM_Validating(object sender, CancelEventArgs e)
        {
            string apellidoM = R_apM.Text;
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(apellidoM))
            {
                errorProvider1.SetError(R_apM, "El nombre solo debe contener letras.");
            }
            else
            {
                errorProvider1.SetError(R_apM, "");

            }
        }

        private void NACIMIENTO_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
